using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Modelo
{
    public class VehiculosBl
    {
        ConexionBl a = new ConexionBl();
        private DataView dv;

        public VehiculosBl() {

            dv = listado().DefaultView;
        
        }
        public DataTable listado() {
            DataTable tb = new DataTable();
                
            try
            {
                a.getA.Close();
           
                a.getA.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Coches WHERE disponible=1 ", a.getA);
                da.Fill(tb);
                a.getA.Close();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
                
               
            }
            return tb;
           
        }

        public DataView filtro(string mar) {

            dv.RowFilter =  "marca like '%"+mar+"%'";
            return dv;
        
        }

        public void compra(string matricula,string id_cliente,int factura)
        {
            string instruccion="";
            try
            {
                a.getA.Close();
                instruccion = "INSERT INTO dbo.Compras(id_cliente,id_coche,id_factura)   VALUES('" + id_cliente + "','" + matricula + "','" + factura + "')";
                a.getA.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Coches WHERE disponible=1 ", a.getA);
                a.getA.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);


            }
        }

    }
}