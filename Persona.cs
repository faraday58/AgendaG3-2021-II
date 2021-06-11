

namespace AgendaG3_2021_II
{
    public class Persona
    {
        private string nombre;
        private string telefono;
        private byte edad;

        public Persona(string nombre, string telefono, byte edad)
        {
            Nombre = nombre;
            Telefono = telefono;
            Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public byte Edad { 
            
            get => edad; 
            set { 

                if( value <= 7 || value >= 70    )
                {
                    edad = 18;
                }
                else
                {
                    edad = value;
                }
               
               }
            }
    }
}
