using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Modelo
{
    public class Crud
    {
        private ConexionBl c;

        public Crud() {

            c = new ConexionBl();

        }

        public void CrearVehiculo(Vehiculos d) {
            String insert = "insert into Coches (matricula, marca, color, modelo, precio) values ('" + d.Placa + "','" + d.Marca + "','" + d.Color + "', '" + d.Modelo + "', '" + d.precio + "')";
        ejecutar(insert);
        }

        public Vehiculos BuscarVehi(string id_vehiculos)
        {
            Vehiculos f = new Vehiculos();

            String select = "select * from Coches where id_Coche = '" + id_vehiculos + "'";
            c.a.Open();
            c.sen = new SqlCommand(select, c.a);
            c.sl = c.sen.ExecuteReader();

            if (c.sl.Read()) {
                f = new Vehiculos();
                f.ID_Vehiculo = c.sl[0].ToString();
                f.Placa = c.sl[1].ToString();
                f.Marca = c.sl[2].ToString();
                f.Color = c.sl[3].ToString();
                f.Modelo = c.sl[4].ToString();
                f.precio = double.Parse(c.sl[5].ToString());
            }
           c.a.Close();

            return f;

        }

        public void ActualizarVehi( Vehiculos g) {
            String Actualizar = "update Coches  set  matricula='" + g.Placa + "',marca = '" + g.Marca + "', color = '" + g.Color + "' , modelo = '" + g.Modelo + "' , precio = '" + g.Precio + "' where id_Coche = '" + g.ID_Vehiculo + "'";
        ejecutar(Actualizar);
        }

        public void BorrarVehi(string id_vehiculos)
        {
            String Borrar = "delete from Coches where id_Coche = '" + id_vehiculos + "'";
            ejecutar(Borrar);
        
        }
        private void ejecutar(String sql) {


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
