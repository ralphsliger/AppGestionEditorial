using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Cientificos : Documentos
    {
        #region "_________________Atributos______________"
        private string tipo;

      
        #endregion 



        #region "____________Propiedades__________________"
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        #endregion

        
        
        
        #region"_________________Constructores______________"

        public Cientificos() : base(){}


        public Cientificos(string codigo, string titulo, string autor, string idioma, string editorial, string categoria, int numeroDePaginas) : base(codigo, titulo, autor, idioma, editorial, categoria, numeroDePaginas) { }

        #endregion

    }
}
