using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactorySystem.Models;

namespace CarFactorySystem.Factory
{
    public class CarFactory
    {
        public static Car GenerateCar(string engineType)
        {
            IEngine engine;
            switch (engineType.ToLower())
            {
                case "gas":
                    engine = new GasEngine();
                    break;

                case "electric":
                    engine = new ElectricEngine();
                    break;

                case "hybrid":
                    engine = new HybridEngine();
                    break;

                default:
                    throw new ArgumentException("Invalid engine type");



            }
            return new Car(engine);

        }
    }
}
