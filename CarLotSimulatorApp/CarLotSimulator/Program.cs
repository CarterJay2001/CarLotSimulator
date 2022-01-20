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
            //var Future = new Car();
            //Future.Year = 2025;
            //Future.Make = "Tesla";
            //Future.Model = "Roadster";
            //Future.EngineNoise = "*silence*";
            //Future.HonkNoise = "Meep Meep";
            //Future.IsDrivable = true;
            //Future.MakeEngineNoise();
            //Future.MakeHonkNoise();

            //var Present = new Car();
            //Present.Year = 2022;
            //Present.Make = "Jeep";
            //Present.Model = "Wrangler Rubicon 392";
            //Present.EngineNoise = "Vroom Vroom";
            //Present.HonkNoise = "Burrr Burrrrr";
            //Present.IsDrivable = true;
            //Present.MakeEngineNoise();
            //Present.MakeHonkNoise();

            //var Past = new Car();
            //Past.Year = 1999;
            //Past.Make = "Oldsmobile";
            //Past.Model = "Cutlass";
            //Past.EngineNoise = "put put put";
            //Past.HonkNoise = "Peep Peep";
            //Past.IsDrivable = false;
            //Past.MakeEngineNoise();
            //Past.MakeHonkNoise();
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var Future = new Car();
            Future.Make = "Tesla";
            Future.Model = "Roadster";
            Future.Year = 2025;
            Future.EngineNoise = "*silence*";
            Future.HonkNoise = "Meep Meep";
            Future.IsDrivable = true;

            var Present = new Car()
            {
                Year = 2022,
                Make = "Jeep",
                Model = "Wrangler Rubicon 392",
                EngineNoise = "Vroom Vroom",
                HonkNoise = "Burrr Burrrrr",
                IsDrivable = true
            };

            var Past = new Car(1999, "Oldsmobile", "Cutlass", "put put put", "Peep Peep", false);
            

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            new CarLot(Future);
            new CarLot(Present);
            new CarLot(Past);
            
            CarLot.PrintCars();
        }
    }
}
