using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1.Transport
{
    public class Bike : ATransport
    {
        int _maxDistance = 10;

        Bike(string type, bool statys, int maxWeight, int baseCost, int costKilometer, int costKilogram) : base(type, statys, maxWeight, baseCost, costKilometer, costKilogram)
        {

        }

        protected override int CalculateCost(Order order)
        {
            return 20 + (5 * order.Kilometer);
        }

        protected override void CanTake(Order order)
        {
            if (MaxWeight <= order.Weight && _maxDistance <= order.Wistance)
            {
                Statys = false;
                Console.WriteLine($"Замовлення {order.Id} взято {Type}");
            }
        }
    }
}
