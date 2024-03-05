using System;
using System.Net.Http.Headers;
using System.Xml;

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
            var Nissan = new car();
            Nissan.Make = "Nissan";
            Nissan.Year = 2019;
            Nissan.Model = "altima";
            Nissan.EngineNoise = "im fast BOY";
            Nissan.HonkNoise = "beeeeep";
            Nissan.IsDriveable = true;

            var Toyota = new car();
            Toyota.Make = "Toyota";
            Toyota.Year = 2006;
            Toyota.Model = "camery";
            Toyota.HonkNoise = "Honk ";
            Toyota.EngineNoise = "I'm slow";
            Toyota.IsDriveable = false;





            var Honda = new car()
            {
                Make = "Honda",
                Year = 2022,
                Model = "Honda ",
                EngineNoise = "I'm iight vrmm ",
                HonkNoise = "Mira Mira",
                IsDriveable = true,
            };

            var tylerCar = new car(2012, "camery", "toyota", "vrrrmmm", "honk", true);


            Console.WriteLine(Toyota.EngineNoise);
            Console.WriteLine(Nissan.EngineNoise);
            Console.WriteLine(Honda.EngineNoise);



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
