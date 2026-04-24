using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactorySystem.Models
{
    public class ElectricEngine : IEngine
    {
        int EngineSpeed ;
        public ElectricEngine()
        {
            EngineSpeed = 0;
        }
        public void IncreaseSpeed()
        {
            EngineSpeed++;
            Console.WriteLine("Increase Speed of Electric Engine By 1km/h");
        }
        public void DecreaseSpeed()
        {
            if(EngineSpeed > 0)
            {
                EngineSpeed--;
            }
           
            Console.WriteLine("Decrease Speed of Electric Engine By 1km/h");

        }

        public void UpdateFromCarSpeed(int CarSpeed)
        {
            EngineSpeed = CarSpeed;
            Console.WriteLine("Electric Engine received car speed: " + CarSpeed + "km/h");

        }
    }
}
