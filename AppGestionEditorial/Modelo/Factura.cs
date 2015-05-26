using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Factura : Cliente
    {

        #region "_____Atributos_______________"

        private int identificacion;
        private string fecha;
        private string item;
        private string sucursal;  
        private string estado;

        #endregion


        #region "____________Propiedades____________________"
        public int Idf
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion


        #region "_____________Constructores_____________"


        public Factura() :base(){

            this.identificacion = 123;
            this.fecha = "26/06/2015";
            this.item = "Articulo";
            this.sucursal = "Lugar";
            this.estado = "Comprado";
        
        }

        public Factura(int codigo, string nombres, string apellidos, string direccion, int telefono, string email,int identificacion,string fecha,string item,string sucursal,string estado) 
            : base( codigo, nombres , apellidos, direccion, telefono, email) {


                this.identificacion = identificacion;
                this.fecha = fecha;
                this.item = item;
                this.sucursal = sucursal;
                this.estado = estado;
        }


        #endregion


        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                               "\nIdf: " + this.identificacion +
                               "\nFecha: " + this.fecha +
                               "\nItem: " + this.item +
                                "\nSucursal: " + this.sucursal +
                                 "\nEstado: " + this.estado +
                               "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Factura o = (Factura)obj;
            bool result = false;

            if (base.Equals(o) && (this.identificacion == o.identificacion) && (this.fecha == o.fecha)
                && (this.item == o.item) && (this.sucursal == o.sucursal) && (this.estado == o.estado))

                result = true;

            return result;
        }
        #endregion
    
    
    }
}