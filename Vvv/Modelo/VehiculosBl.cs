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

        public VehiculosBl()
        {

            dv = listado().DefaultView;

        }
        public DataTable listado()
        {
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

        public DataView filtro(string mar)
        {

            dv.RowFilter = "marca like '%" + mar + "%'";
            return dv;

        }
        //public DataTable longin(user )
        //{
        //    a.getA.Close();

        //    a.getA.Open();
        //    SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Usuarios Where id_usuarios = '" + user+ "'and ds_login='" + TextBox2.Text + "'", a.getA);

        //    a.getA.Close();
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    if (dt.Rows[0][0].ToString() == "1")
        //    {
        //    }
        //    else
        //    {
        //        Label3.Visible = true;
        //    }
        //}


    }
}