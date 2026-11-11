using Module_1.Transport;
using Module_1;
using System;
using System.Collections.Generic;
using System.Text;
using static Module_1.DeliveryService;

namespace Module_1
{
    public interface IFunctionality
    {
        public void AddTransport(ATransport transport);
        public void AddOrder(Order order);
        public void GetCostDelivery(Order order);
        public void AssingOrder(ATransport transport, Order order);
        public void Deliver(Order order, bool PaymentMethod);
        public void GetInfoOrderActive();
        public void GetInfoOrderHistory();
        public void GetInfoTransport();
    }
}
