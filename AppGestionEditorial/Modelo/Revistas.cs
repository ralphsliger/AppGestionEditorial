using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Revistas : Documentos
    {


        #region "_______Atributos____________"

        private int numerovolumen;
        private int numeroarticulos;

        #endregion

        #region "_________Propiedades__________"

        public int Numerovolumen
        {
            get { return numerovolumen; }
            set { numerovolumen = value; }
        }
        public int Numeroarticulos
        {
            get { return numeroarticulos; }
            set { numeroarticulos = value; }
        }

        #endregion

        #region "______Constructores_________"

        public Revistas():base(){

            this.numerovolumen = 2;
            this.numeroarticulos = 2;

        }
        
      public Revistas():base() { }
        public Revistas(string codigo, string titulo, string autor,  string idioma , string editorial , string categoria , int numeroDePaginas) : base(codigo,titulo,autor,idioma,editorial,categoria,numeroDePaginas){
            this.numerovolumen = numerovolumen;
            this.numeroarticulos = numeroarticulos;

        
        }

        
            

        
        

        #endregion

        #region "Métodos SobreEscritos"

        public override string ToString()
        {
            return base.ToString() +
                               "\nNumero de volumenes: " + this.numerovolumen +
                               "\nNumero de Articulos: " + this.numeroarticulos +
                               
                               "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Revistas o = (Revistas)obj;
            bool result = false;

            if (base.Equals(o) && (this.numerovolumen== o.numerovolumen) && (this.numeroarticulos == o.numeroarticulos)
                )

                result = true;

            return result;
        }
        #endregion

    }
}