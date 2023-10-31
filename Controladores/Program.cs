using EjercicioSumaAdd.Servicios;

namespace EjercicioSumaAdd.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperacionesInterfaz oi = new OperacionesImplementacion();


            int numeroE;
            numeroE = mi.pedirNumeroEntero();

            double numeroD;
            numeroD = mi.pedirNumeroDouble();

            double aux = oi.hacerCalculo(numeroD, numeroE);









        }
    }
}