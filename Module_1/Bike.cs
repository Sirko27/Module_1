using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public class Bike : ATransport
    {
        Bike(string type, bool statys, int maxWeight, int baseCost, int costKilometer, int costKilogram) : base(type, statys, maxWeight, baseCost, costKilometer, costKilogram)
        {

        }



        public override int CalculateCost(Order order)
        {
            return 20 + (5 * order.Kilometer);
        }
    }
}
