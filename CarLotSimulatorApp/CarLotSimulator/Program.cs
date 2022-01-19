using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var Future = new Car();
            Future.Make = "Tesla";
            Future.Model = "Roadster";
            Future.Year = 2025;
            Future.EngineNoise = "*silence*";
            Future.HonkNoise = "Meep Meep";
            Future.MakeEngineNoise();
            Future.MakeHonkNoise();

            var Present = new Car();
            Present.Make = "Jeep";
            Present.Model = "Wrangler Rubicon 392";
            Present.Year = 2022;
            Present.EngineNoise = "Vroom Vroom";
            Present.HonkNoise = "Burrr Burrrrr";
            Present.MakeEngineNoise();
            Present.MakeHonkNoise();

            var Past = new Car();
            Past.Make = "Oldsmobile";
            Past.Model = "Cutlass";
            Past.Year = 1999;
            Past.EngineNoise = "put put put";
            Past.HonkNoise = "Peep Peep";
            Past.MakeEngineNoise();
            Past.MakeHonkNoise();
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
