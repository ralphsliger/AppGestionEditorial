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
    public class DocumentosRepositories
    {
        private static List<Documentos> data = new List<Documentos>();

        public List<Documentos> getDocumentos()
        {
            // Creamos la lista genérica de Personas
            List<Documentos> lista = new List<Documentos>();
            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/Datos/Editorial.xml");

            XDocument doc = XDocument.Load(ruta);

            var people = from p in doc.Descendants("Documentos") select p;

            foreach (XElement p in people.Elements("Documento"))
            {
                Documentos docu = new Documentos(
                                                  p.Element("codigo").Value,
                                                  p.Element("titulo").Value,
                                                  p.Element("idiomas").Value,
                                                  p.Element("autores").Value,
                                                  int.Parse(p.Element("paginas").Value),
                                                  p.Element("editorial").Value,
                                                  p.Element("fechaPublicacion").Value,
                                                  p.Element("genero").Value,
                                                  p.Element("fechaPublicacion").Value
                                              );
                lista.Add(docu);

            }


            return lista;
        }

        public void add(Documentos c)
        {
            data.Add(c);
            WriteXML(data);

        }

        // ESCRIBIENDO XML
        private void WriteXML(List<Documentos> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Editorial.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Documentos c in list)
            {
                xmlwriter.WriteStartElement("Documento");
                xmlwriter.WriteElementString("codigo", c.Codigo);
                xmlwriter.WriteElementString("titulo", c.Titulo);
                xmlwriter.WriteElementString("idiomas", c.Idiomas);
                xmlwriter.WriteElementString("autores", c.Autores);
                xmlwriter.WriteElementString("paginas", c.NPaginas.ToString());
                xmlwriter.WriteElementString("editorial", c.Editorial);
                xmlwriter.WriteElementString("fechaPublicacion", c.FechaPulicacion);
                xmlwriter.WriteElementString("genero", c.Genero);
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