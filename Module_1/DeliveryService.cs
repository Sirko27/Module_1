using Module_1.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public class DeliveryService : IFunctionality
    {
        readonly List<ATransport> _transports = new();
        readonly List<Order> _ordersActive = new();
        readonly List<Order> _ordersHistory = new();

        public void AddTransport(ATransport transport)
        {
            _transports.Add(transport);
        }

        public void GetCostDeliveryNotActiveTranspoprt(Order order)
        {
            foreach (ATransport t in _transports)
            {
                if (t.CanTake(order))
                    Console.WriteLine($"{t.Type} доставить замовлення {order.Id} за: {t.CalculateCost(order)} грн");
            }
        }

        public void AssingOrder(ATransport transport, Order order)
        {
            if (transport.Statys == false)
            {
                if (transport.CanTake(order))
                {
                    Console.WriteLine($"{transport.Type} взяв замовлення номер: {order.Id}");
                    transport.Statys = true;
                    _ordersActive.Add(order);
                    order.AssignedTransport = transport;
                    return;
                }
            }

            Console.WriteLine("Немає доступного транспорту");
        }

        public void Deliver(Order order)
        {
            if (order.PaymentMethod == true)
                Console.WriteLine("Замовлення доставлено та оплачено картою");
            else
                Console.WriteLine("Замовлення доставлено та оплачено готівкою");

            _ordersActive.Remove(order);
            _ordersHistory.Add(order);

            if (order.AssignedTransport != null)
                order.AssignedTransport.Statys = false;
        }

        public void GetInfoOrderActive()
        {
            foreach (Order o in _ordersActive)
            {
                Console.WriteLine($"Замовлення {o.Id}, вага: {o.Weight}кг, відстань:{o.Distance}, " +
                    $"оплата: {(o.PaymentMethod ? "карта" : "готівка")}, опис: {o.Description}");
            }
        }

        public void GetInfoOrderHistory()
        {
            foreach (Order o in _ordersHistory)
            {
                Console.WriteLine($"Замовлення {o.Id}, вага: {o.Weight}кг, відстань:{o.Distance}, " +
                    $"оплата: {(o.PaymentMethod ? "карта" : "готівка")}, опис: {o.Description}");
            }
        }
    }
}
