using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Modelo
{
    public class CrudPersonas
    {


        private ConexionBl c;

        public CrudPersonas()
        {

            c = new ConexionBl();

        }

        public void CrearPerso(Personas d)
        {
            String insert = "insert into Clientes (Identificacion, tipo_Identificacion, nombre,direccion,ciudad,disponible) values ('" + d.documentoID + "','" + d.tipoDocumentoID + "','" + d.Nombre + "', '" + d.direccion + "', '" + d.ciudad + "',  '" + d.Disponible + "')";
            ejecutar(insert);
        }

        public Personas BuscarPerso(string Id)
        {
            Personas f = new Personas();

            String select = "select * from Clientes where id_Cliente = '" + Id + "'";
            c.a.Open();
            c.sen = new SqlCommand(select, c.a);
            c.sl = c.sen.ExecuteReader();

            if (c.sl.Read())
            {
                f = new Personas();
                f.ID = c.sl[0].ToString();
                f.documentoID = c.sl[1].ToString();
                f.tipoDocumentoID = c.sl[2].ToString();
                f.Nombre = c.sl[3].ToString();
                f.Direccion = c.sl[4].ToString();
                f.Ciudad = c.sl[5].ToString();
                f.Disponible = c.sl[6].ToString();
            }
            c.a.Close();

            return f;

        }

        public void ActualizarPerso(Personas g)
        {
            String Actualizar = "update Clientes  set  Identificacion='" + g.documentoID + "',tipo_Identificacion = '" + g.tipoDocumentoID + "', nombre = '" + g.Nombre + "' , direccion = '" + g.Direccion + "' , ciudad = '" + g.Ciudad + "' where id_Cliente = '" + g.ID + "'";
            ejecutar(Actualizar);
        }

        public void BorrarPers(string id)
        {
            String Borrar = "delete from Coches where id_Coche = '" + id + "'";
            ejecutar(Borrar);
        
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