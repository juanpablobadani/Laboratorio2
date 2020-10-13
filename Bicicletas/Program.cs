using System;

namespace Bicicletas
{
    class Program
    {
        static void Main(string[] args)
        {
            electricBike bike = new electricBike();
            Console.WriteLine("Cantidad de Bateria: " + bike.cantBatery());
            bike.cargarBatery(50);
            bike.bikeRoute("Cercado", "Tiquipaya");
            Console.WriteLine("Cantidad de Bateria: " + bike.cantBatery());

        }
    }
}
