using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Revistas : Documentos
    {
        #region "Atributos"
        private int numeroVolumen;

     
        private int numeroArticulos;

       
#endregion
#region "propiedades"
        public int NumeroVolumen
        {
            get { return numeroVolumen; }
            set { numeroVolumen = value; }
        }

        public int NumeroArticulos
        {
            get { return numeroArticulos; }
            set { numeroArticulos = value; }
        }


#endregion

      #region metodos
      #endregion


      public Revistas():base() { }
        public Revistas(string codigo, string titulo, string autor,  string idioma , string editorial , string categoria , int numeroDePaginas) : base(codigo,titulo,autor,idioma,editorial,categoria,numeroDePaginas){}
         

    }
}
