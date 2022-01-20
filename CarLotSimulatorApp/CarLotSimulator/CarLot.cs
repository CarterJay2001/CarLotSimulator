using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static List<Car> carlot = new List<Car>() { };

        public CarLot(Car car)
        {
            carlot.Add(car);
        }

        public static void PrintCars ()
        {
            var count = 1;
            foreach (Car car in carlot)
            {
                Console.WriteLine($"Car number {count}: {car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();

                count++;
            }
        }
    }
}
