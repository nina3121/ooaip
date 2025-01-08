using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class IrrigationSystem
    {
        public void WaterPlants()
        {
            for (int i = 1; i < 25; i++)
            {
                if (i % 6 == 0)
                {
                    Console.WriteLine("watering the plants");
                }
            }
        }
    }
}
