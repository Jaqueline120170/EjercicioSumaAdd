using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSumaAdd.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        public double hacerCalculo (double numeroD, int numeroE)
        {
            double aux = 1;
            for (int i = 0; i < numeroE; i++)
            {
                aux = aux * numeroD;
                
            }
            Console.WriteLine(aux);

            return aux;
        }
         
            
            
    }
    
    
    
}
