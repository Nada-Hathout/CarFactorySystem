using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactorySystem.Models
{
    public class HybridEngine : IEngine
    {
        private bool IsElectricEngine;
        private GasEngine gasEngine;
        private ElectricEngine electric_Engine;
        public HybridEngine()
        {
            IsElectricEngine = true;
            gasEngine = new GasEngine();
            electric_Engine = new ElectricEngine();
        }
        public void IncreaseSpeed()
        {
            if (IsElectricEngine)
            {
                electric_Engine.IncreaseSpeed();
            }
            else
            {
                gasEngine.IncreaseSpeed();
            }
        }

        public void DecreaseSpeed()
        {
            if (IsElectricEngine)
            {
                electric_Engine.DecreaseSpeed();
            }
            else
            {
                gasEngine.DecreaseSpeed();
            }
        }

        public void UpdateFromCarSpeed(int CarSpeed)
        {
            if (CarSpeed < 50)
            {
                IsElectricEngine = true;
                electric_Engine.UpdateFromCarSpeed(CarSpeed);
            }
            else
            {
                IsElectricEngine = false;

                gasEngine.UpdateFromCarSpeed(CarSpeed);

            }
        }
    }
}
