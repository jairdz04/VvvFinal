using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace Vvv.Modelo
{
    public class ConexionBl
    {
        public SqlConnection a;
        public SqlCommand sen;
        public SqlDataReader sl;

        public ConexionBl()
        {

            a = new SqlConnection("workstation id=UtbDesarollo.mssql.somee.com;packet size=4096;user id=jairdz04_SQLLogin_1;pwd=j3sag4ub94;data source=UtbDesarollo.mssql.somee.com;persist security info=False;initial catalog=UtbDesarollo");
             
        }

        public SqlConnection getA
        {
            get
            {
                return a;
            }


        }


    }
}