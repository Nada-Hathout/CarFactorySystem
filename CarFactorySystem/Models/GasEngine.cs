using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactorySystem.Models
{
    public class GasEngine : IEngine
    {
        int EngineSpeed;
        public GasEngine()
        {
            EngineSpeed = 0;
        }
        public void IncreaseSpeed()
        {
            EngineSpeed++;
            Console.WriteLine("Increase Speed of Gas Engine By 1km/h");
        }


        public void DecreaseSpeed()
        {
            if (EngineSpeed>0)
            {
                EngineSpeed--;
            }
            
            Console.WriteLine("Decrease Speed of Gas Engine By 1km/h");
        }

      
        public void UpdateFromCarSpeed(int CarSpeed)
        {
            EngineSpeed = CarSpeed;
            Console.WriteLine("Gas Engine received car speed " + CarSpeed + "km/h");
        }
    }
}
