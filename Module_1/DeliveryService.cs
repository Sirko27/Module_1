using Module_1.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public class DeliveryService : IFunctionality
    {
        public void GetCostDeliveryNotActiveTranspoprt(ATransport[] transport, Order[] order)
        {
            for (int i = 0; i < transport.Length; i++)
            {
                for (int j = 0; j < order.Length; j++)
                {
                    if (transport[i].CanTake(order[j]))
                        Console.WriteLine($"{transport[i].Type} доставить замовлення {order[j].Id} за: {transport[i].CalculateCost(order[j])} грн");
                }
            }
        }

        public void AssingOrder(ATransport transport, Order order)
        {
            if (transport.Statys == false)
            {
                if (transport.CanTake(order))
                {
                    Console.WriteLine($"{transport.Type} взяв замовлення номер: {order.Id}");
                    transport.Statys = false;
                    return;
                }
            }

            Console.WriteLine("Немає доступного транспорту");
        }

        public void Deliver(ATransport transport, Order order)
        {
            transport.Statys = true;

            if (order.PaymentMethod == true)
                Console.WriteLine("Замовлення доставлено та оплачено карою");
            else
                Console.WriteLine("Замовлення доставлено та оплачено готівкою");
        }

        public void GetInfoOrder(Order[] orders)
        {
            foreach (Order order in orders)
            {
                Console.WriteLine($"Замовлення {order.Id}, вага: {order.Weight}кг, відстань:{order.Distance}, " +
                    $"оплата: {(order.PaymentMethod ? "карта" : "готівка")}, опис: {order.Description}");
            }
        }
    }
}
