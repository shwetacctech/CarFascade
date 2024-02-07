using CarFascade.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFascade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFacade car = new CarFacade();
            car.StartCar();
            Console.WriteLine("Driving for a while...");
            car.StopCar();
            Console.ReadKey();
        }
    }
}
