using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validacion de inputs vacios
            if (ValidarCampos())
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int edad = int.Parse(txtEdad.Text);
                string direccion = txtDireccion.Text;

                User usuario = new User(nombre, apellido, edad, direccion);

                string resultado = "Apellido y Nombre: " + usuario.Apellido + " " + usuario.Nombre + Environment.NewLine +
                    "Edad: " + usuario.Edad + Environment.NewLine +
                    "Direccion: " + usuario.Direccion;

                txtResultado.Text = resultado;
            }
                
        }

        public bool ValidarCampos()
        {

            List<Control> Vacios = new List<Control>();
            Control edad = null;
            foreach (Control item in Controls)
            {
                if (item is TextBox && string.IsNullOrEmpty(item.Text) && item != txtResultado)
                {
                    item.BackColor = Color.MistyRose;
                    Vacios.Add(item);
                }
                else if (item == txtEdad && !(int.TryParse(item.Text, out _)))
                {
                    edad = item;
                }
            }

            if (Vacios.Count > 0)
            {
                MessageBox.Show("Sos boludo, te olvidaste de completar algunos campos.");
                return false;
            }
            else if (edad != null)
            {
                MessageBox.Show("El formato de la edad es incorrecto.");
                return false;
            }
            else
                return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
