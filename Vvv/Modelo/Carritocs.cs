using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vvv.Modelo
{
    public class Carritocs
    {
        string cod;

        public string Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        string mat;

        public string Mat
        {
            get { return mat; }
            set { mat = value; }
        }
        string mar;

        public string Mar
        {
            get { return mar; }
            set { mar = value; }
        }
        string col;

        public string Col
        {
            get { return col; }
            set { col = value; }
        }
        int mod;

        public int Mod
        {
            get { return mod; }
            set { mod = value; }
        }
        double pre;

        public double Pre
        {
            get { return pre; }
            set { pre = value; }
        }
        int cant;

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }

        public Carritocs(string cod, string mat, string mar, string col, int mod, double pre, int cant)
        {
            this.cod = cod;
            this.mat = mat;
            this.mar = mar;
            this.col = col;
            this.pre = pre;
            this.cant = cant;
      
        }

    }
}