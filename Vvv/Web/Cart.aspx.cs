using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vvv.Modelo;
using System.Collections;
using System.Data;
namespace Vvv.Web
{
    public partial class Cart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
if (!IsPostBack) {
                if (Request.Cookies["dato"] == null)
                {
                    Response.Redirect("Catalog.aspx");

                }
                else {

                    Codigo.Text = Request.Cookies["dato"].Values["Codigo"];
                    Matricula.Text = Request.Cookies["dato"].Values["Matricula"];
                    Marca.Text = Request.Cookies["dato"].Values["Marca"];
                    Color.Text = Request.Cookies["dato"].Values["Color"];
                    Modelo.Text = Request.Cookies["dato"].Values["Modelo"];
                    Precio.Text = Request.Cookies["dato"].Values["Precio"];

                }
            
            
            }

        }

        //protected void btnAgregar_Click(object sender, EventArgs e)
        //{
        //   /* CartDetails tabla = new CartDetails();
        //    Session["carrito"] = tabla.getTabla(); */

        //    CartDetailsBL tabla = new CartDetailsBL((DataTable)Session["carrito"]);
        //    string message = tabla.agregar(int.Parse(Codigo.Text), Matricula.Text, Marca.Text, Color.Text, int.Parse(Modelo.Text), int.Parse(Precio.Text), int.Parse(TextBox2.Text));

        //    ClientScript.RegisterStartupScript(typeof(Page), "alert", "<script language=JavaScript>alert('" + (message) + "'); </script>");

        //    Session["carrito"] = tabla.getRegistro;
        //}

     
        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
        // CartDetailsBL tabla = new CartDetailsBL((DataTable)Session["carrito"]);
           // CartDetails tabla = new CartDetails();
            CartDetailsBL tabla = CartDetailsBL.CapturarProducto();
            tabla.agregar(Codigo.Text, Matricula.Text, Marca.Text, Color.Text, int.Parse(Modelo.Text), double.Parse(Precio.Text),1);
            Response.Redirect("Factura1.aspx");
           
            //Session["carrito"] = tabla.getRegistro;
           // string message = tabla.agregar(Codigo.Text, Matricula.Text, Marca.Text, Color.Text, int.Parse(Modelo.Text), double.Parse(Precio.Text), int.Parse(TextBox2.Text));

         //   ClientScript.RegisterStartupScript(typeof(Page), "alert", "<script language=JavaScript>alert('" + (message) + "'); </script>");

            
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnRegresar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Catalog.aspx");

        }

       

       

       

      

       
    }
}