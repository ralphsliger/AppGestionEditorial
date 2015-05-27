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
    public class ClientesRepositories
    {
        private static List<Clientes> data = new List<Clientes>();
        
        public List<Clientes> getPersonas()
        {
          // Creamos la lista genérica de Personas
            List<Clientes> lista = new List<Clientes>();
           // Obtenemos la ruta de archivo XML
          string ruta = HttpContext.Current.Server.MapPath("/Datos/Cliente.xml");

          XDocument doc = XDocument.Load(ruta);

          var people = from p in doc.Descendants("Clientes") select p;

          foreach (XElement p in people.Elements("Cliente"))
          {
              Clientes cliente = new Clientes(
                                                p.Element("ID").Value,
                                                p.Element("Nombres").Value,
                                                p.Element("Apellidos").Value,
                                                p.Element("Email").Value,
                                                p.Element("Telefono").Value
                  
                                            );
              lista.Add(cliente);

          }
          
   
         return lista;
        }

        public void add(Clientes p)
        {
            data.Add(p);
            WriteXML(data);

        }

        private void WriteXML(List<Clientes> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/clientes.xml"), System.Text.Encoding.UTF8);
            
            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Clientes");
            //Call create nodes method
            foreach(Clientes p in list)
            {
                xmlwriter.WriteStartElement("Cliente");
                xmlwriter.WriteElementString("ID", p.Id);
                xmlwriter.WriteElementString("Nombres", p.Nombres);
                xmlwriter.WriteElementString("Apellidos", p.Apellidos);
                xmlwriter.WriteElementString("Email", p.Email);
                xmlwriter.WriteElementString("Telefono", p.Telefono);
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