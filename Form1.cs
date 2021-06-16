using System;
using System.Collections;
using System.Windows.Forms;

namespace AgendaG3_2021_II
{
    public partial class Form1 : Form
    {
        //Persona[] personas;
        ArrayList personas;
        int indice;

        public Form1()
        {
            InitializeComponent();
            //  personas = new Persona[3];
            lbResultado.Text = "";
            personas = new ArrayList();
        }

        public int Indice { get => indice;
            set
            {
                if(value >= personas.Count || value < 0  )
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
            //personas[Indice++] = new Persona(txtbNombre.Text, txtbTelefono.Text,byte.Parse( txtbEdad.Text));
            personas.Add( new Persona(txtbNombre.Text, txtbTelefono.Text, byte.Parse(txtbEdad.Text)) );

            txtbNombre.Clear();
            txtbTelefono.Clear();
            txtbEdad.Clear();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Persona persona;
            if (personas.Count != 0)
            {
                if (personas[Indice] != null)
                {
                    persona = (Persona)personas[Indice];
                    txtbNombre.Text = persona.Nombre;
                    txtbTelefono.Text = persona.Telefono;
                    txtbEdad.Text = persona.Edad.ToString();
                    Indice++;
                }
                else
                {
                    MessageBox.Show("No hay más personas que mostrar");
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(personas[Indice] !=null )
            {
                Persona persona =(Persona)personas[Indice];
                DialogResult boton= MessageBox.Show( "¿Está seguro de eliminar a " + persona.Nombre + "?", "Eliminar persona de la Agenda",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if(boton == DialogResult.OK )
                {
                    personas.RemoveAt(Indice);
                    lbResultado.Text = "Operación realizada con Éxito";                    
                }
                
            }
        }
    }
}
