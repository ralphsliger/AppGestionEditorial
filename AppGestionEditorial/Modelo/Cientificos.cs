using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Cientificos : Documentos

    {

        public Cientificos() : base(){}


        public Cientificos(string autor, string NombreDocumento, string genero, int año, string idiomaDocumento):base(autor, NombreDocumento,genero, año,idiomaDocumento ) { }



    }
}