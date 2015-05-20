using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Formatos : Documentos 
    {

        public Formatos() : base() { }

        public Formatos(string autor, string NombreDocumento, string genero, int año, string idiomaDocumento) : base(autor,NombreDocumento, genero, año, idiomaDocumento) { }




    }
}