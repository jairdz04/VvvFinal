using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Modelo
{
    public class CartDetailsBL
    {
        private DataTable registro;

        public List<Carritocs> ListaProductos { get; private set; }
        protected CartDetailsBL()
        {
            ListaProductos = new List<Carritocs>();
        }

        public static CartDetailsBL CapturarProducto()
        {
            CartDetailsBL _carrito = (CartDetailsBL)HttpContext.Current.Session["ASPCarroDeCompras"];
            if (_carrito == null)
            {
                HttpContext.Current.Session["ASPCarroDeCompras"] = _carrito = new CartDetailsBL();
            }
            return _carrito;
        }




        public DataTable getRegistro
        {
            get
            {

                return registro;
            }
        }
        public void agregar(string cod, string mat, string mar, string col, int mod, double pre, int cant)
        {
            Carritocs NuevoProducto = new Carritocs(cod, mat, mar, col, mod, pre, cant);
            if (ListaProductos.Count > 0)
            {
                foreach (Carritocs item in ListaProductos)
                {
                    if (item.Cod.Equals(cod))
                    {


                    }
                    else
                    {
                        NuevoProducto.Cant = 1;
                        ListaProductos.Add(NuevoProducto);
                    }
                }

            }
            else
            {
                NuevoProducto.Cant = 1;
                ListaProductos.Add(NuevoProducto);
            }
            Cargartabla();
        }
        public void EliminarProductos(string cod)
        {
            try
            {
                foreach (Carritocs item in ListaProductos)
                {
                    if (item.Cod.Equals(cod))
                    {
                        ListaProductos.Remove(item);

                    }
                }

            }
            catch (Exception ex)
            {

            }

        }

        public void compra(string id_cliente, string factura)
        {
            ConexionBl a = new ConexionBl();
            string instruccion = "";
            try
            {
                a.getA.Close();

                a.getA.Open();
                foreach (Carritocs item in ListaProductos)
                {
                    instruccion = "INSERT INTO dbo.Compras(id_cliente,id_coche,id_factura)   VALUES('" + id_cliente + "','" + item.Mat + "','" + factura + "')";
                    a.sen = new SqlCommand(instruccion, a.getA);
                    a.sen.ExecuteNonQuery();
                }
                a.getA.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);


            }

        }

        public void Cargartabla()
        {
            registro = new DataTable();
            registro.Columns.Add("CODIGO", Type.GetType("System.String"));
            registro.Columns.Add("MATRICULA", Type.GetType("System.String"));
            registro.Columns.Add("MARCA", Type.GetType("System.String"));
            registro.Columns.Add("COLOR", Type.GetType("System.String"));
            registro.Columns.Add("MODELO", Type.GetType("System.Int32"));
            registro.Columns.Add("PRECIO", Type.GetType("System.Double"));
            registro.Columns.Add("CANTIDAD", Type.GetType("System.Int32"));
            registro.Columns.Add("TOTAL", Type.GetType("System.Double"), "Precio*Cantidad");
            registro.TableName = "carros";
            try
            {
                DataRow fila = registro.NewRow();
                foreach (Carritocs c in ListaProductos)
                {
                    fila = registro.NewRow();
                    fila[0] = c.Cod;
                    fila[1] = c.Mat;
                    fila[2] = c.Mar;
                    fila[3] = c.Col;
                    fila[4] = c.Mod;
                    fila[5] = c.Pre;
                    fila[6] = c.Cant;
                    registro.Rows.Add(fila);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public double total()
        {
            double t = 0;
            try
            {
                foreach (Carritocs it in ListaProductos)
                {
                    t = t + (it.Pre * it.Cant);
                }


            }
            catch (Exception ex)
            {

            }


            return t;
        }

    }
}