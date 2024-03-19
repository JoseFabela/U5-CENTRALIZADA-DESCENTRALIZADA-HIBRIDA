using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5
{
    public partial class Form1 : Form
    {
        private List<string> archivosCargados = new List<string>();
        private string tipoOrganizacion = "";
        private bool usuarioSeleccionoCentralizado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarArchivos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string archivo in openFileDialog.FileNames)
                {
                    archivosCargados.Add(archivo);
                    listBoxArchivos.Items.Add(Path.GetFileName(archivo));
                }
            }
        }

        private void btnAlmacenar_Click(object sender, EventArgs e)
        {
            if (tipoOrganizacion == "")
            {
                MessageBox.Show("Por favor, seleccione un tipo de organización primero.");
                return;
            }

            foreach (string archivo in archivosCargados)
            {
                if (tipoOrganizacion == "centralizada")
                {
                    MessageBox.Show($"Archivo {Path.GetFileName(archivo)} almacenado en el servidor central.");
                }
                else if (tipoOrganizacion == "descentralizada")
                {
                    MessageBox.Show($"Archivo {Path.GetFileName(archivo)} almacenado en el dispositivo local.");
                }
                else if (tipoOrganizacion == "híbrida")
                {
                    if (usuarioSeleccionoCentralizado)
                    {
                        MessageBox.Show($"Archivo {Path.GetFileName(archivo)} almacenado en el servidor central.");
                    }
                    else
                    {
                        MessageBox.Show($"Archivo {Path.GetFileName(archivo)} almacenado en el dispositivo local.");
                    }
                }
            }

            archivosCargados.Clear();
            listBoxArchivos.Items.Clear();
        }

        private void radioBtnCentralizada_CheckedChanged(object sender, EventArgs e)
        {
            tipoOrganizacion = "centralizada";

        }

        private void radioBtnDescentralizada_CheckedChanged(object sender, EventArgs e)
        {
            tipoOrganizacion = "descentralizada";

        }

        private void radioBtnHibrida_CheckedChanged(object sender, EventArgs e)
        {
            tipoOrganizacion = "híbrida";

        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            if (archivosCargados.Count == 0)
            {
                MessageBox.Show("No hay archivos para organizar.");
                return;
            }

            // Crear una carpeta para organizar los archivos por fecha
            string carpetaPrincipal = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ArchivosOrganizados");
            Directory.CreateDirectory(carpetaPrincipal);

            foreach (string archivo in archivosCargados)
            {
                try
                {
                    // Obtener la fecha de creación del archivo
                    DateTime fechaCreacion = File.GetCreationTime(archivo);

                    // Crear una carpeta con el formato "YYYY-MM-DD"
                    string carpetaFecha = Path.Combine(carpetaPrincipal, fechaCreacion.ToString("yyyy-MM-dd"));
                    Directory.CreateDirectory(carpetaFecha);

                    // Mover el archivo a la carpeta correspondiente
                    string nombreArchivo = Path.GetFileName(archivo);
                    string rutaDestino = Path.Combine(carpetaFecha, nombreArchivo);
                    File.Move(archivo, rutaDestino);

                    MessageBox.Show($"El archivo {nombreArchivo} fue organizado en la carpeta {carpetaFecha}.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al organizar el archivo {Path.GetFileName(archivo)}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //archivosCargados.Clear();
            //listBoxArchivos.Items.Clear();
        }

        

        

        private void radioBtnCentralizadoHibrido_CheckedChanged(object sender, EventArgs e)
        {
            tipoOrganizacion = "híbrida";
            usuarioSeleccionoCentralizado = true;
        }

        private void radioBtnDescentralizadoHibrido_CheckedChanged(object sender, EventArgs e)
        {
            tipoOrganizacion = "híbrida";
            usuarioSeleccionoCentralizado = false;
        }
    }
}
