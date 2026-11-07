using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public abstract class ATransport
    {
        string Type;
        bool Statys;
        int MaxWeight;
        int BaseCost;
        int CostKilometer;
        int CostKilogram;

        abstract void CalculateCost(Order order);
        virtual void CanTake(Order order);
    }
}
