using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vvv.Modelo;

namespace Vvv.Web
{
    public partial class Catalog : System.Web.UI.Page
    {

        VehiculosBl b = new VehiculosBl();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GridView1.DataSource = b.listado();
                GridView1.DataBind();
            }

        }

        

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = b.listado();
            GridView1.DataBind();

        }
       

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int f = GridView1.SelectedIndex;
            HttpCookie dato = new HttpCookie("dato");

            dato.Values.Add("Codigo", GridView1.Rows[f].Cells[1].Text);
            dato.Values.Add("Matricula", GridView1.Rows[f].Cells[2].Text);
            dato.Values.Add("Marca",Server.HtmlDecode(GridView1.Rows[f].Cells[3].Text));
            dato.Values.Add("Color", GridView1.Rows[f].Cells[4].Text);
            dato.Values.Add("Modelo", GridView1.Rows[f].Cells[5].Text);
            dato.Values.Add("Precio", GridView1.Rows[f].Cells[6].Text);

            Response.Cookies.Add(dato);
            Response.Redirect("Cart.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = b.filtro(TextBox1.Text);
            GridView1.DataBind();
        }

        
    }
}