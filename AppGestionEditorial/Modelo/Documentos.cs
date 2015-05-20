using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Documentos
    {
#region  "__                                Atributos                     ____"

        private string codigo;


        private string titulo;


        private string autor;



       private string idioma;



        private string editorial;



        private string categoria;



        private int numeroDePaginas;


        

    
     



#endregion

        #region "_____ Propiedades     "

       public string Codigo
{
  get { return codigo; }
  set { codigo = value; }
}

public string Titulo
{
  get { return titulo; }
  set { titulo = value; }
}

public string Autor
{
  get { return autor; }
  set { autor = value; }
}

        public string Idioma
{
  get { return idioma; }
  set { idioma = value; }
}

        public string Editorial
{
  get { return editorial; }
  set { editorial = value; }
}



        public string Categoria
{
  get { return categoria; }
  set { categoria = value; }
}

        public int NumeroDePaginas
{
  get { return numeroDePaginas; }
  set { numeroDePaginas = value; }
}
   
        #endregion 

        #region "____Constructores____"

        public Documentos()
        {
            this.codigo = "XXXXX";
            this.titulo = "XXXXX";
            this.autor = "XXXXX";
            this.idioma= "XXXXXX";
            this.categoria = "XXXXX";
            this.editorial = "XXXXXX";
            this.numeroDePaginas= 0;

        }

        public Documentos(string codigo, string titulo, string autor,string idioma, string categoria,string editorial,int numeroDePaginas ){
            this.codigo= codigo;
            this.titulo=titulo;
            this.autor= autor;
             this.idioma= idioma;
            this.categoria= categoria;
            this.editorial= editorial;
            this.numeroDePaginas= numeroDePaginas;


        }
        

        }


        #endregion 

#region "___________ Metodos _______________ "

    public override string ToString()
{
    return "\nCodigo: " + this.codigo +
       "\nNombreDocumento:" + this.titulo +
      "\nAutor:"+ this.autor +
       "\nCategoria:" + this.categoria +
        "\nIdiomaDocumento:"+ this.idioma +
      "\nNumeroDePaginas"+ this.numeroDePaginas +
        "\nAño:" + this.año;

}

pubc override bool equals(objetc obj)
{
    Documentos o = (Documentos)obj;
    bool result = false;

    if ((this.autor == o.autor)) &&
        (this.nombreDocumento == o.nombreDocumento) &&
        (this.genero == o.genero) &&
        (this.idiomaDocumento == o.idiomaDocumento) &&
        (this.año == o.año))

    result = true;

    return result;


}
    public override int GetHashCode()
{
    return this.ToString().GetHashCode();

}
}









#endregion 






    }
}
