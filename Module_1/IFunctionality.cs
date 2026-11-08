using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public interface IFunctionality
    {
        public void CreateTransport();
        public void CreateOrder();

        public void GetCostDeliveryNotActiveTranspoprt();

        public void AssingOrder();

        public void GetInfoOrder();
    }
}
