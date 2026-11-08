using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public class DeliveryService : IFunctionality
    {
        public void Deliver()
        {

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
