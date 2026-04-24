using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactorySystem.Models
{
    public class Car
    {
        private IEngine engine;
        private int CarSpeed;

        private const int carMaxSpeed = 200;
        private const int speedStep = 20;
        public Car(IEngine _engine)
        {
            engine = _engine;
            CarSpeed = 0;
        }


        public void ChangeEngine(IEngine NewEngine) { 
        engine = NewEngine;
            Console.WriteLine($"Successfully Changed the Engine To {NewEngine.GetType().Name}");
        }

        public void Start() {
            CarSpeed = 0;
            engine.UpdateFromCarSpeed(CarSpeed);
            Console.WriteLine("Car Started Now");
        }
        public void Stop()
        {
            if (CarSpeed == 0) {
                Console.WriteLine("Car is Already Stopped ");
                return;
            }
               
            while (CarSpeed > 0)
            {
                Brake();
            }
            Console.WriteLine("Car Stopped Now");
        }

        public void Accelerate()
        {
            if (CarSpeed < carMaxSpeed)
            {
                CarSpeed += speedStep;
                engine.UpdateFromCarSpeed(CarSpeed);
                engine.IncreaseSpeed();

                Console.WriteLine("car speeded up");
            }
            else
            {
                Console.WriteLine("car reach top speed");

            }
        }

        public void Brake()
        {
            if (CarSpeed > 0)
            {
                CarSpeed -= speedStep;
                engine.UpdateFromCarSpeed(CarSpeed);
                engine.DecreaseSpeed();
                Console.WriteLine("car Slow Down");
                    
            }


        }
    }
}
