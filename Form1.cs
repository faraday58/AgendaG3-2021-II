using System;
using System.Windows.Forms;

namespace AgendaG3_2021_II
{
    public partial class Form1 : Form
    {
        Persona[] personas;
        int indice;

        public Form1()
        {
            InitializeComponent();
            personas = new Persona[3];
        }

        public int Indice { get => indice;
            set
            {
                if(value > 2   )
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
            } 
                
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            personas[Indice++] = new Persona(txtbNombre.Text, txtbTelefono.Text,byte.Parse( txtbEdad.Text));

            txtbNombre.Clear();
            txtbTelefono.Clear();
            txtbEdad.Clear();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (personas[Indice] != null)
            {
                txtbNombre.Text = personas[Indice].Nombre;
                txtbTelefono.Text = personas[Indice].Telefono;
                txtbEdad.Text = personas[Indice].Edad.ToString();
                Indice++;
            }
            else
            {
                MessageBox.Show("No hay más personas que mostrar");
            }
        }
    }
}
