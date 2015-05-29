using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vvv.Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Web
{
    public partial class Support : System.Web.UI.Page
    {

        CrudSoporte h = new CrudSoporte();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string codigo = TextBox1.Text;
          Soporte v = h.Buscar(codigo);

            if (h != null)
            {

                TextBox2.Text = v.placa_carro;
                TextBox3.Text = v.tipo_revision;
                TextBox4.Text = v.observacion;
               



            }
            else
            {




            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Soporte j = new Soporte();

            j.tipo_revision = TextBox2.Text;
            j.placa_carro = TextBox3.Text;
            j.observacion = TextBox4.Text;
           

           h.Crear(j);

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
           
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

            TextBox1.Focus();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox5.Text = "";
            TextBox5.Focus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Facturar b = new Facturar(TextBox5.Text);
            GridView1.DataSource = b.listado(TextBox5.Text);
            GridView1.DataBind();
        }
    }
}