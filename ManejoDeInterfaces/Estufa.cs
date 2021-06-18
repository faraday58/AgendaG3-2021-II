using System;
using System.Threading;

namespace ManejoDeInterfaces
{
    class Estufa:IApagar,IEncender
    {
        public void Encender()
        {
            Console.WriteLine("Bienvenido a tu estufa\n ¿Qué deseas disfrutar hoy?");
        }

        void IApagar.Apagar()
        {
            
            Console.WriteLine(" Apagando Estufa  ");
            string indicador = ".";
            for (int i=0; i < 3; i++)
            {
                Console.Write(indicador);
                indicador += ".";
                Thread.Sleep(1000);
            }
        }

    }
}
