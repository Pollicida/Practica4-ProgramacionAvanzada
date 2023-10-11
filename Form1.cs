using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace Práctica5_programación_avanzada_Vs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = tbNombre.Text;
            string Apellido = tbApellidos.Text; 
            string Telefono = tbTeléfono.Text;
            string Edad = tbEdad.Text;
            string Estatura = tbEstatura.Text;
            string Genero="";
            if (rbHombre.Checked==true)
            {
                Genero = "Hombre";
            }
            else
            {
                if (rbMujer.Checked==true)
                {
                    Genero = "Mujer";
                }
            }
            //Creación de la cadena con los datos
            string datos = $"Nombres: {Nombre}\r\n Apellidos: {Apellido}\r\n Telefono:{Telefono} \r\n Estatura: {Estatura} cm\r\nEdad:{Edad} años\r\n Genero {Genero}";

            //Guardar los datos en un archivo de texto 
            string rutaarchivo = "C:/Users/CRISTIAN/OneDrive/Documentos/LIDTS/Datos.txt";

            //Verificar si el archivo existe ya existe
            bool archivoexiste = File.Exists(rutaarchivo);
            if(archivoexiste==false)
            {
                File.WriteAllText(rutaarchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaarchivo, true))
                {
                    if (archivoexiste)
                    {
                        writer.WriteLine();

                    }
                    writer.WriteLine(datos);
                }
            }
            MessageBox.Show($"Los datos han sido guardados correctamente\r\nNombres: {Nombre}\r\nApellidos: {Apellido}\r\nTelefono:{Telefono} kg\r\nEstatura: {Estatura} cm\r\nEdad:{Edad} años\r\nGenero: {Genero}");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEdad.Clear();
            tbEstatura.Clear();
            tbTeléfono.Clear();
            rbHombre.Checked =false;
            rbMujer.Checked =false;
        }
    }
}
