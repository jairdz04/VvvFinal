using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vvv.Modelo
{
    public class Soporte
    {
        public string idConsulta;
        public string placa_carro;
        public string tipo_revision;
        public string observacion;

        public string IdConsulta
        {
            get { return idConsulta; }
            set { idConsulta = value; }
        }
        public string Placa_carro
        {
            get { return placa_carro; }
            set { placa_carro = value; }
        }
        public string Tipo_revision
        {
            get { return tipo_revision; }
            set { tipo_revision = value; }
        }
        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

         public Soporte()
        {
            this.idConsulta = "";
            this.placa_carro = "";
            this.tipo_revision = "";
            this.observacion = "";

        }

 public Soporte(string idConsulta, string placa_carro, string tipo_revision, string observacion)
        {

            this.idConsulta = idConsulta;
            this.placa_carro = placa_carro;
            this.tipo_revision = tipo_revision;
            this.observacion = observacion;
           
        }

 public override string ToString()
 {
     return "Codigo: " + this.idConsulta +
             "\nCedula: " + this.placa_carro +
             "\nTipo ID: " + this.tipo_revision +
             "\nDNombre: " + this.observacion;

            
 }

 public override int GetHashCode()
 {
     return this.ToString().GetHashCode();
 }
 public override bool Equals(object obj)
 {
     Soporte o = (Soporte)obj;
     bool result = false;

     if ((this.idConsulta== o.idConsulta) &&
         (this.placa_carro== o.placa_carro) &&
         (this.tipo_revision == o.tipo_revision) &&
         (this.observacion == o.observacion))

         result = true;

     return result;
 }


    }
}