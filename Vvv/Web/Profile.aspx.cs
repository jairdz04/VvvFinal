using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Web
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection a = new SqlConnection("Server=JAIRDIAZ\\SQLEXPRESS; Database= UtbDesarrollo; Integrated Security=true");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Usuarios Where id_usuarios = '" + TextBox1.Text + "'and ds_login='" + TextBox2.Text + "'", a);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                Session["UserID"] = TextBox1.Text;
                Response.Redirect("Admin.aspx");

            }
            else
            {
                Label3.Visible = true;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

            Label3.Visible = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }
    }
}