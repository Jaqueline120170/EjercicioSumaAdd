using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSumaAdd.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNumeroEntero()
        {
            Console.WriteLine("Introduzca un numero entero: ");
            int numeroE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número entero introducido es: " + numeroE);
            return numeroE;
        }

        public double pedirNumeroDouble()
        {
            Console.WriteLine("Introduzca un numero double: ");
            double numeroD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El numero double introducido es: " + numeroD);
            return numeroD;

        }
    }
}