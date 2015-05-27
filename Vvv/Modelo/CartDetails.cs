using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace Vvv.Modelo
{
    public class CartDetails
    {

      
        private DataTable tabla = new DataTable();
       
        public CartDetails(){
            
            
                }


        public String agregar(string cod, string mat, string mar, string col, int mod, double pre, int cant)
        
        {

            tabla.Columns.Add("CODIGO", Type.GetType("System.String"));
            tabla.Columns.Add("MATRICULA", Type.GetType("System.String"));
            tabla.Columns.Add("MARCA", Type.GetType("System.String"));
            tabla.Columns.Add("COLOR", Type.GetType("System.String"));
            tabla.Columns.Add("MODELO", Type.GetType("System.Int32"));
            tabla.Columns.Add("PRECIO", Type.GetType("System.Double"));
            tabla.Columns.Add("CANTIDAD", Type.GetType("System.Int32"));
            tabla.Columns.Add("TOTAL", Type.GetType("System.Double"), "Precio*Cantidad");
            tabla.TableName = "carros";
            //tabla.Rows.Add();
            // tabla.PrimaryKey = new DataColumn[] { tabla.Columns[0] };

            string msg = "";

            try
            {
                DataRow fila = tabla.NewRow();
                if (fila == null)
                {
                    msg = "Ya existe en el carrito";


                }
                else
                {
                    
                        fila = tabla.NewRow();
                        fila["CODIGO"] = cod;
                        fila["MATRICULA"] =mat;
                        fila["MARCA"] = mar;
                        fila["COLOR"] = col;
                        fila["MODELO"] = mod;
                        fila["PRECIO"] = pre;
                        fila["CANTIDAD"] =cant;
                        tabla.Rows.Add(fila);
                   


                    msg = "Añadido al Carrito";
                }




            }
            catch (Exception ex)
            {


            }

            return msg;
        
        
        }

        public double total()
        {
            double t = 0;
            try
            {
                if (tabla.Rows.Count > 0)
                {

                    t = (double)tabla.Compute("sum(total", "");
                }
            }
            catch (Exception ex)
            {

            }


            return t;
        }

        public DataTable getTabla {
            get {
                return tabla;
            }
        }
    }
}