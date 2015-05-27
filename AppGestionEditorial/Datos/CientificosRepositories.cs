using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Web.Hosting;
using System.IO;
using System.Xml.Linq;
using App.Web;
using App.Modelo;






namespace App.Datos
{
    public class CientificosRepositories
    {
        private static List<Cientificos> data = new List<Cientificos>();

        public List<Cientificos> getDocumentos()
        {
            // Creamos la lista genérica de Personas
            List<Cientificos> lista = new List<Cientificos>();
            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/Datos/Editorial.xml");

            XDocument doc = XDocument.Load(ruta);

            var people = from p in doc.Descendants("Documentos") select p;

            foreach (XElement p in people.Elements("Documento"))
            {
                Cientificos docu = new Cientificos(
                                                  p.Element("codigo").Value,
                                                  p.Element("titulo").Value,
                                                  p.Element("idiomas").Value,
                                                  p.Element("autores").Value,
                                                  int.Parse(p.Element("paginas").Value),
                                                  p.Element("editorial").Value,
                                                  p.Element("fechaPublicacion").Value,
                                                  p.Element("genero").Value,
                                                  p.Element("fechaPublicacion").Value,
                                                  p.Element("tipo").Value
                                              );
                lista.Add(docu);

            }


            return lista;
        }

        public void add(Cientificos c)
        {
            data.Add(c);
            WriteXML(data);

        }

        // ESCRIBIENDO XML
        private void WriteXML(List<Cientificos> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Editorial.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Cientificos c in list)
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
                xmlwriter.WriteElementString("tipo", c.Tipo);
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