using System;
using System.Threading;

namespace ManejoDeInterfaces
{
    class Refrigerador : IApagar,IEncender
    {
        public void Apagar()
        {
            Console.WriteLine(" Apagando Refrigerador  ");
            string indicador = "*";
            for (int i = 0; i < 3; i++)
            {
                Console.Write(indicador);
                indicador += "*";
                Thread.Sleep(1000);
            }
        }

        public void Encender()
        {
            Console.WriteLine("Bienvenido a tu refrigerador \n Temperatura actual es la del Ambiente");
        }
    }
}
