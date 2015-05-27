using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;
using System.Xml;
using System.Web.Hosting;
using System.IO;
using System.Xml.Linq;


namespace App.Datos
{
    public class LibrosRepositories
    {
        private static List<Libros> data = new List<Libros>();

        public List<Libros> getDocumentos()
        {
            // Creamos la lista genérica de Personas
            List<Libros> lista = new List<Libros>();
            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/Datos/Editorial.xml");

            XDocument doc = XDocument.Load(ruta);

            var people = from p in doc.Descendants("Documentos") select p;

            foreach (XElement p in people.Elements("Documento"))
            {
                Libros docu = new Libros(
                                                  p.Element("codigo").Value,
                                                  p.Element("titulo").Value,
                                                  p.Element("idiomas").Value,
                                                  p.Element("autores").Value,
                                                  int.Parse(p.Element("paginas").Value),
                                                  p.Element("editorial").Value,
                                                  p.Element("fechaPublicacion").Value,
                                                  p.Element("genero").Value,
                                                  p.Element("fechaPublicacion").Value,
                                                  int.Parse(p.Element("capitulos").Value),
                                                  int.Parse(p.Element("tomos").Value),
                                                  p.Element("nivel").Value
                                              );
                lista.Add(docu);

            }


            return lista;
        }

        public void add(Libros c)
        {
            data.Add(c);
            WriteXML(data);

        }

        // ESCRIBIENDO XML
        private void WriteXML(List<Libros> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Editorial.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Libros c in list)
            {
                xmlwriter.WriteStartElement("Documento");
                xmlwriter.WriteElementString("codigo", c.Codigo);
                xmlwriter.WriteElementString("titulo", c.Titulo);
                xmlwriter.WriteElementString("idiomas", c.Idiomas);
                xmlwriter.WriteElementString("autores", c.Autores);
                xmlwriter.WriteElementString("paginas", c.NPaginas.ToString());
                xmlwriter.WriteElementString("editorial", c.Editorial);
                xmlwriter.WriteElementString("fechaPublicacion", c.FechaPulicacion);
                xmlwriter.WriteElementString("fechaEdicion", c.FechaEdicion);
                xmlwriter.WriteElementString("categoria", c.Genero);
                xmlwriter.WriteElementString("capitulos", c.Capitulos.ToString());
                xmlwriter.WriteElementString("tomos", c.Tomos.ToString());
                xmlwriter.WriteElementString("nivel", c.Nivel);
                xmlwriter.WriteElementString("formatos", c.NFormato);
                xmlwriter.WriteElementString("permisos", c.listPermisos);
                xmlwriter.WriteEndElement();
            }

            xmlwriter.WriteEndElement();

            //End XML Document
            xmlwriter.WriteEndDocument();

            //Close Write
            xmlwriter.Close();
        }
        
    }
}