using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Formatos : Documentos 
    {

        public Formatos() : base() { }

        public Formatos(string codigo, string titulo, string autor, string idioma, string editorial, string categoria, int numeroDePaginas) : base(codigo, titulo, autor, idioma, editorial, categoria, numeroDePaginas) { }



    }
}
