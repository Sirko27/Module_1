using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1.Transport
{
    public abstract class ATransport
    {
        public string Type { get; set; }
        public bool Statys { get; set; }
        public int MaxWeight { get; set; }
        public int BaseCost { get; set; }
        public int CostKilometer { get; set; }
        public int CostKilogram { get; set; }

        protected ATransport(string type, bool statys, int maxWeight, int baseCost, int costKilometer, int costKilogram)
        {
            this.Type = type;
            this.Statys = statys;
            this.MaxWeight = maxWeight;
            this.BaseCost = baseCost;
            this.CostKilometer = costKilometer;
            this.CostKilogram = costKilogram;
        }

        public abstract double CalculateCost(Order order);
        public virtual bool CanTake(Order order)
        {
            if (MaxWeight >= order.Weight)
                return true;

            return false;
        }
    }
}
