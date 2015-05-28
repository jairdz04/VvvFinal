using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Modelo
{
    public class CrudSoporte
    {

 private ConexionBl c;

        public CrudSoporte() {

            c = new ConexionBl();

        }

        public void Crear(Soporte d)
        {
           
            String insert = "insert into Taller (carro, tipo_Revicion, observacion) values ('" + d.placa_carro + "','" + d.tipo_revision + "', '" + d.observacion + "')";
            ejecutar(insert);
            
        }

        /*public returnId (string id)
          {
        String cod = "select"
        }*/
        public Soporte Buscar(string cod)
        {
            Soporte f = new Soporte();

            String select = "select * from Taller where id_taller = '" + cod + "'";
            c.a.Open();
            c.sen = new SqlCommand(select, c.a);
            c.sl = c.sen.ExecuteReader();

            if (c.sl.Read())
            {
                f = new Soporte();
                f.idConsulta = c.sl[0].ToString();
                f.placa_carro = c.sl[1].ToString();
                f.tipo_revision = c.sl[2].ToString();
                f.observacion = c.sl[5].ToString();
                
            }
            c.a.Close();

            return f;

        }
        public void ActualizarRespuesta(string respuesta, string id_taller)
        {
            String Actualizar = "update Taller  set  observacion='" + respuesta + "' where id_taller = '" + id_taller + "'";
            ejecutar(Actualizar);
        }


        private void ejecutar(String sql)
        {


            try
            {
                c.a.Open();
                c.sen = new SqlCommand(sql, c.a);
                c.sen.ExecuteNonQuery();
                c.a.Close();

            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}