using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Modelo
{
    public class Facturar
    {
     ConexionBl a = new ConexionBl();
        private DataView dv;

        public Facturar(string id_factura)
        {

            dv = listado(id_factura).DefaultView;

        }
        public DataTable listado(string id_factura)
        {
            DataTable tb = new DataTable();
            string instruccion = "";
            try
            {
                a.getA.Close();
                /* "SELECT factura='compra.id_factura,client.nombre,Producto='Placa'" +  + "',tipo_Identificacion = '" + g.tipoDocumentoID + "', nombre = '" + g.Nombre + "' , direccion = '" + g.Direccion + "' , ciudad = '" + g.Ciudad + "' where id_Cliente = '" + g.ID + "'";
                " SELECT factura='compra.id_factura,client.nombre,Producto='Placa '+c.matricula+' Auto '+c.marca+' '+c.color+'  modelo '+c.modelo,Precio=c.precio,Fecha='compra.fecha_compra FROM Compras compra INNER JOIN Clientes client ON client.Identificacion = compra.id_cliente INNER JOIN Coches c ON c.matricula = compra.id_coche WHERE compra.id_factura='" + id_factura + "'";*/
                instruccion = "SELECT factura='compra.id_factura,client.nombre,Producto='Placa '+c.matricula+' Auto '+c.marca+' '+c.color+'  modelo '+c.modelo,Precio=c.precio,Fecha='compra.fecha_compra FROM Compras compra INNER JOIN Clientes client ON client.Identificacion = compra.id_cliente INNER JOIN Coches c ON c.matricula = compra.id_coche WHERE compra.id_factura='" + id_factura + "'";
                SqlDataAdapter da = new SqlDataAdapter(instruccion, a.getA);
                da.Fill(tb);
                a.getA.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);


            }
            return tb;

        }

        
    }
}