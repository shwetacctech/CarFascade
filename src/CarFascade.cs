using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFascade.src
{
     public class CarFacade
    {
        private Engine _engine;
        private Transmission _transmission;
        private Wheels _wheels;

        public CarFacade()
        {
            _engine = new Engine();
            _transmission = new Transmission();
            _wheels = new Wheels();
        }

        // Method to start the car
        public void StartCar()
        {
            _engine.Start();
            _transmission.ShiftGear();
            _wheels.Rotate();
            Console.WriteLine("Car started and ready to drive");
        }

        // Method to stop the car
        public void StopCar()
        {
            _engine.Stop();
            Console.WriteLine("Car stopped");
        }
    }

}
