using Module_1.Transport;

using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public interface IFunctionality
    {
        public void GetCostDeliveryNotActiveTranspoprt(ATransport[] transport, Order[] order);
        public void AssingOrder(ATransport transport, Order order);
        public void Deliver(ATransport transport, Order order);
        public void GetInfoOrder(Order[] orders);
    }
}
