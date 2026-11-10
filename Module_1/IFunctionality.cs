using Module_1.Transport;

using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public interface IFunctionality
    {
        public void AddTransport(ATransport transport);
        public void GetCostDeliveryNotActiveTranspoprt(Order order);
        public void AssingOrder(ATransport transport, Order order);
        public void Deliver(Order order);
        public void GetInfoOrderActive();
        public void GetInfoOrderHistory();
    }
}
