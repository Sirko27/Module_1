using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    public class Order
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Distance { get; set; }
        public bool PaymentMethod { get; set; }//1-карта 0-готівка
        public string? Description { get; set; }

        Order(int id, int weight, int distance, string description)
        {
            Id = id;
            Weight = weight;
            Distance = distance;
            Description = description;
        }

    }
}
