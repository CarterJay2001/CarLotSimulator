using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car(int year, string make, string model, string enginenoise, string honknoise, bool isdriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDrivable = isdriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"Car go: {EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"{HonkNoise}\n");
        }
    }
}
