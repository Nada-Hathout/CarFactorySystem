using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactorySystem.Models
{
    public interface IEngine
    {
        void IncreaseSpeed();
        void DecreaseSpeed();
        void UpdateFromCarSpeed(int speed);
    }
}
