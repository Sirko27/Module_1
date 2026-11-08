using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1.Transport
{
    public class Truck: ATransport
    {
        Truck(string type, bool statys, int maxWeight, int baseCost, int costKilometer, int costKilogram)
            : base(type, statys, maxWeight, baseCost, costKilometer, costKilogram)
        {

        }

        protected override int CalculateCost(Order order)
        {
            return 50 + (15 * order.Distance) + (0,5 * order.Weight);
        }
    }
}
