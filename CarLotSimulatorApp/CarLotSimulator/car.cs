using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class car
    {
        public car(int year, 
                   string make,
                   string model, 
                   string honkNoise, 
                   string engineNoise, 
                   bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            HonkNoise = honkNoise; 
            EngineNoise = engineNoise;
            IsDriveable = isDrivable;

        }

        public car() { }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }


    }
   
    
    
}
