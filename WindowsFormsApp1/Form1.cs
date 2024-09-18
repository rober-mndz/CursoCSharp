using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<User> usuarios = new List<User>();
        public int contador = 0;
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            float peso = float.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);

            usuarios.Add(new User(nombre, apellido, peso, altura));

            if (progressBar1.Value < 100 && contador <= 4)
            {
                progressBar1.Value += 25;
                GridUsers.Rows.Add(usuarios[contador].Nombre, usuarios[contador].Apellido, usuarios[contador].Peso, usuarios[contador].Altura);
                MessageBox.Show("Cargue otro usuario");
                contador++;
                
            }
            else
            {
                MessageBox.Show("BASTA...");
            }
                

        }

    
        

    }
}
