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
            numeroE = mi.PedirNumeroEntero();

            double numeroD;
            numeroD = mi.PedirNumeroDouble();

            double aux = oi.hacerCalculo;









        }
    }
}