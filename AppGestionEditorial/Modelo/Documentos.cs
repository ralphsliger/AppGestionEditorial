using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Documentos
    {
#region  "__                                Atributos                      ____"

        private string autor;

       
        private string NombreDocumento;

        
        private string genero;


        private int año;

        

        
        private string idiomaDocumento;

        


#endregion

        #region "_____ Propiedades     "

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string NombreDocumento1
        {
            get { return NombreDocumento; }
            set { NombreDocumento = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }


        public string IdiomaDocumento
        {
            get { return idiomaDocumento; }
            set { idiomaDocumento = value; }
        }
 




        #endregion 

        #region "____Constructores____"

        public Documentos()
        {
            this.autor = "XXXXX";
            this.NombreDocumento = "XXXXX";
            this.idiomaDocumento = "XXXXX";
            this.genero = "XXXXX";
            this.año = 0;
        }

        public Documentos(string autor, string nombreDocumento,string genero,int año){
            this.autor= autor;
            this.NombreDocumento= nombreDocumento;
            this.genero= genero;
            this.año= año;


        }

        




        

        }


        #endregion 

    }
}