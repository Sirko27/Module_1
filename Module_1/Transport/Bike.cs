using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1.Transport
{
    public class Bike : ATransport
    {
        public readonly int _maxDistance = 10;

        public Bike(string type, bool statys, int maxWeight, int baseCost, int costKilometer, int costKilogram) : base(type, statys, maxWeight, baseCost, costKilometer, costKilogram)
        {

        }

        public override double CalculateCost(Order order)
        {
            return 20 + (5 * order.Distance);
        }

        public override bool CanTake(Order order)
        {
            if (MaxWeight >= order.Weight && _maxDistance >= order.Distance)
                return true;

            return false;
        }
    }
}
