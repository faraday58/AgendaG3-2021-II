using System;

namespace ManejoDeInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IApagar apagarEstufa = new Estufa();
            apagarEstufa.Apagar();
            Estufa estufa = new Estufa();
            Console.WriteLine();
            estufa.Encender();


            //Esta sintaxis es más transparente para el desarrollador
            Refrigerador refrigerador = new Refrigerador();
            IApagar apagarRefri = (IApagar)refrigerador;
            apagarRefri.Apagar();
            Console.WriteLine();

            //Referencia simple que mejora el encapsulamiento, pero es 
            //más complicado de identificar las clases asociadas
            refrigerador.Encender();
            


            Console.ReadLine();
            //refrigerador.Apagar();

        }
    }
}
