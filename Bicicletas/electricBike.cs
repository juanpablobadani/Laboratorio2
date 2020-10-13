using System;
using System.Collections.Generic;
using System.Text;

namespace Bicicletas
{
    class electricBike : Acctions, IBatery
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public float fuelTank { get; set; }

        public electricBike()
        {
            fuelTank = 0;
        }

        public void speedUp()
        {

        }
        public void bikeRoute(string origen, string destino)
        {
            Advance();
            Console.Write("su ruta es de " + origen + " a " + destino + "\n");
            fuelTank = fuelTank - 10;
            Brake();

        }

        public void turnOntheLights()
        {

        }

        public void tireSize()
        {


        }

        public float cantBatery()
        {
            return fuelTank;
        }

        public void cargarBatery(float cant)
        {
            fuelTank = fuelTank + cant;

            Console.WriteLine(" la bateria se recargo un  " + cant + " % ");

        }
    }
}
