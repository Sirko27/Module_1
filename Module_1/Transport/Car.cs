using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1.Transport
{
    public class Car : ATransport
    {
        public Car(string type, bool statys, int maxWeight, int baseCost, int costKilometer, int costKilogram)
            : base(type, statys, maxWeight, baseCost, costKilometer, costKilogram)
        {

        }

        public override double CalculateCost(Order order)
        {
            return 50 + (8 * order.Distance) + order.Weight;
        }
    }
}
