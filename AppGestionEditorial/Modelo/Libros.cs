using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Libros : Documentos
        
    {
#region "_____________Atributos_____________"
        private int numeroCapitulos;


      private   int numeroTomos;


#endregion 


#region "___________Propiedades___________"
        public int NumeroCapitulos
{
  get { return numeroCapitulos; }
  set { numeroCapitulos = value; }
}

        public int NumeroTomos
{
  get { return numeroTomos; }
  set { numeroTomos = value; }
}


#endregion 

        
        
        #region "__________Constructores__________"

        public Libros() :base(){ }

        public Libros(string codigo, string titulo, string autor,  string idioma , string editorial , string categoria , int numeroDePaginas) : base(codigo,titulo,autor,idioma,editorial,categoria,numeroDePaginas){
            this.numeroCapitulos = numeroCapitulos;
            this.numeroTomos = numeroTomos;

        }


#endregion 
    }
}
