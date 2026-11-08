using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1.Transport
{
    public abstract class ATransport
    {
        protected string Type { get; set; }
        protected bool Statys { get; set; }
        protected int MaxWeight { get; set; }
        protected int BaseCost { get; set; }
        protected int CostKilometer { get; set; }
        protected int CostKilogram { get; set; }

        protected ATransport(string type, bool statys, int maxWeight, int baseCost, int costKilometer, int costKilogram)
        {
            this.Type = type;
            this.Statys = statys;
            this.MaxWeight = maxWeight;
            this.BaseCost = baseCost;
            this.CostKilometer = costKilometer;
            this.CostKilogram = costKilogram;
        }

        protected abstract int CalculateCost(Order order);
        protected virtual void CanTake(Order order)
        {
            if(MaxWeight<=order.weight)
            {
                Statys = false;
                Console.WriteLine($"Замовлення {order.Id} взято {Type}");
            }
        }
    }
}
