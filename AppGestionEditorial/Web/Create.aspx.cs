using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Modelo;
using App.Datos;

namespace App.Web
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string nFormato = formatodoc.SelectedItem.Value;

            Formatos formato = new Formatos("000", nFormato, chLeer.Checked, chGuardar.Checked, chImprimir.Checked,
                chEditar.Checked, chEscuchar.Checked, chVisualizar.Checked);
            
            string docu_type = type.SelectedItem.Value;


            if (docu_type == "documentos")
            {
                Documentos p = new Documentos(
                                        txtCodigo.Text,
                                        txtTitulo.Text,
                                        txtIdiomas.Text,
                                        txtAutores.Text,
                                        int.Parse(txtNpaginas.Text),
                                        txtEditorial.Text,
                                        txtFechaP.Text,
                                        txtGenero.Text,
                                        txtFechaP.Text
                                       );

                p.addFormato(formato);

                DocumentosRepositories data = new DocumentosRepositories();

                data.add(p);
            }

            if (docu_type == "libros")
            {
                Libros p = new Libros(
                                        txtCodigo.Text,
                                        txtTitulo.Text,
                                        txtIdiomas.Text,
                                        txtAutores.Text,
                                        int.Parse(txtNpaginas.Text),
                                        txtEditorial.Text,
                                        txtFechaP.Text,
                                        txtGenero.Text,
                                        txtFechaE.Text,
                                        int.Parse(txtnCapitulos.Text),
                                        int.Parse(txtTomos.Text),
                                        nivelLibro.SelectedItem.Value
                                       );

                p.addFormato(formato);

                LibrosRepositories data = new LibrosRepositories();

                data.add(p);
            }

            if (docu_type == "revistas")
            {
                Revistas p = new Revistas(
                                        txtCodigo.Text,
                                        txtTitulo.Text,
                                        txtIdiomas.Text,
                                        txtAutores.Text,
                                        int.Parse(txtNpaginas.Text),
                                        txtEditorial.Text,
                                        txtFechaP.Text,
                                        txtGenero.Text,
                                        txtFechaE.Text,
                                        int.Parse(txtVolumenes.Text),
                                        int.Parse(txtArticulos.Text)
                                       );

                p.addFormato(formato);

                RevistasRepositories data = new RevistasRepositories();

                data.add(p);
            }

            if (docu_type == "cientificos")
            {
                Cientificos p = new Cientificos(
                                        txtCodigo.Text,
                                        txtTitulo.Text,
                                        txtIdiomas.Text,
                                        txtAutores.Text,
                                        int.Parse(txtNpaginas.Text),
                                        txtEditorial.Text,
                                        txtFechaP.Text,
                                        txtGenero.Text,
                                        txtFechaE.Text,
                                        txtTipo.Text
                                       );

                p.addFormato(formato);

                CientificosRepositories data = new CientificosRepositories();

                data.add(p);
            }
            


        }
    }
}