using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Vvv.Modelo
{
    public class Personas
    {
        #region "Atributos"
        public string ID;
        public string documentoID;
        public string tipoDocumentoID;
        public string Nombre;

        public string Ciudad;
        public string Direccion;

        public string Disponible;

        #endregion

        #region "Propiedades"
        public string Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Cc
        {
            get { return documentoID; }
            set { documentoID = value; }
        }

        public string tipo
        {
            get { return tipoDocumentoID; }
            set { tipoDocumentoID = value; }
        }


        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }



        public string ciudad
        {
            get { return Ciudad; }
            set { Ciudad = value; }
        }

        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }




        public string disponible
        {
            get { return Disponible; }
            set { Disponible = value; }
        }



        #endregion

        #region "contructores"
        public Personas()
        {
            this.ID = "";
            this.documentoID = "";
            this.tipoDocumentoID = "";
            this.nombre = "";

            this.Ciudad = "";
            this.Direccion = "";

            this.Disponible = "";



        }

        public Personas(string ID, string documentoID, string tipoDocumentoID, string Nombre, string Ciudad, string Direccion, string Disponible)
        {

            this.ID = ID;
            this.documentoID = documentoID;
            this.tipoDocumentoID = tipoDocumentoID;
            this.Nombre = Nombre;
            this.Ciudad = Ciudad;
            this.Direccion = Direccion;
            this.Disponible = Disponible;
        }


        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "Codigo: " + this.ID +
                    "\nCedula: " + this.documentoID +
                    "\nTipo ID: " + this.tipoDocumentoID +
                    "\nDNombre: " + this.Nombre +

                    "\nCiudad: " + this.Ciudad +
                    "\nDireccion: " + this.Direccion +

                    "\nTelefono: " + this.Disponible;

        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Personas o = (Personas)obj;
            bool result = false;

            if ((this.ID == o.ID) &&
                (this.documentoID == o.documentoID) &&
                (this.tipoDocumentoID == o.tipoDocumentoID) &&
                (this.Nombre == o.Nombre) &&
                (this.Ciudad == o.Ciudad) &&

                (this.Direccion == o.Direccion) &&

                (this.Disponible == o.Disponible))

                result = true;

            return result;
        }

        #endregion

    }


    }
