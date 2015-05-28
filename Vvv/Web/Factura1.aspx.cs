using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vvv.Modelo;
using System.Data;


namespace Vvv.Web
{
    public partial class Factura1 : System.Web.UI.Page
    {
        CrudPersonas h = new CrudPersonas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*  */

                CartDetailsBL tabla = CartDetailsBL.CapturarProducto();
                tabla.Cargartabla();
                GridView1.DataSource = tabla.getRegistro;
                GridView1.DataBind();
                // BindData();
                Label2.Text = tabla.total().ToString();
            }
        }
        protected void BindData()
        {
            GridView1.DataSource = CartDetailsBL.CapturarProducto().ListaProductos;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int f = GridView1.SelectedIndex;
            CartDetailsBL.CapturarProducto().EliminarProductos(GridView1.Rows[f].Cells[1].Text);

            Response.Redirect("Factura1.aspx");
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            CartDetailsBL tabla = CartDetailsBL.CapturarProducto();
            tabla.compra(TextBox1.Text, TextBox7.Text);
            CartDetailsBL.CapturarProducto().ListaProductos.Clear();
            Response.Redirect("Factura1.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string codigo = TextBox1.Text;
            Personas v = h.BuscarPerso(codigo);

            if (h != null)
            {

                TextBox2.Text = v.tipoDocumentoID;
                TextBox3.Text = v.documentoID;
                TextBox4.Text = v.Nombre;
                TextBox5.Text = v.Direccion;
                TextBox6.Text = v.Ciudad;



            }
            else
            {




            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Personas j = new Personas();

            j.tipoDocumentoID = TextBox2.Text;
            j.documentoID = TextBox3.Text;
            j.Nombre = TextBox4.Text;
            j.Direccion = TextBox5.Text;
            j.Ciudad = TextBox6.Text;

            h.CrearPerso(j);
            reset1();
        }

        
        protected void Button3_Click(object sender, EventArgs e)
        {
            Personas k = new Personas();

            k.tipoDocumentoID = TextBox2.Text;
            k.documentoID = TextBox3.Text;
            k.Nombre = TextBox4.Text;
            k.Direccion = TextBox5.Text;
            k.Ciudad = TextBox6.Text;

            h.ActualizarPerso(k);
        }
        public void reset1()
        {

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox1.Focus();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            reset1();
        }
    }
}