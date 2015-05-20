using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Libros : Documentos
    {
        public Libros() :base(){ }

        public Libros(string autor, string NombreDocumento, string genero, int año, string idiomaDocumento):base(autor, NombreDocumento,genero, año,idiomaDocumento ) { }
)

    }
}