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
    public partial class Admin : System.Web.UI.Page
    {
        Crud h = new Crud();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null)
            {

                Label1.Text = "Sesión iniciada :  " + Session["UserID"].ToString();

            }
            else
            {

                Label1.Text = "Por favor inicie sesión";
                Button1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("UserID");
            Session.RemoveAll();
            Response.Redirect("Profile.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string codigo = TextBox1.Text;
            Vehiculos v = h.BuscarVehi(codigo);

            if (h != null)
            {

                TextBox2.Text = v.Placa;
                TextBox3.Text = v.Marca;
                TextBox4.Text = v.Color;
                TextBox5.Text = v.Modelo;
                TextBox6.Text = v.Precio.ToString();



            }
            else
            {




            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Vehiculos j = new Vehiculos();

            j.Placa = TextBox2.Text;
            j.Marca = TextBox3.Text;
            j.Color = TextBox4.Text;
            j.Modelo = TextBox5.Text;
            j.Precio = double.Parse(TextBox6.Text);

            h.CrearVehiculo(j);

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
            Vehiculos k = new Vehiculos();

            k.Placa = TextBox2.Text;
            k.Marca = TextBox3.Text;
            k.Color = TextBox4.Text;
            k.Modelo = TextBox5.Text;
            k.Precio = double.Parse(TextBox6.Text);

            h.ActualizarVehi(k);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String codigo = TextBox1.Text;
            h.BorrarVehi(codigo);

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox1.Focus();
        }



    }
}