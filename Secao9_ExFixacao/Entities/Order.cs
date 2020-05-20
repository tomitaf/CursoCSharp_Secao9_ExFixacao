using System;
using Secao9_ExFixacao.Entities.Enums;
using System.Collections.Generic;

namespace Secao9_ExFixacao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus Status)
        {
            Moment = moment;
            Status = Status;
        }

        public void AddOrder(OrderItem orderItem)
        {
            OrderItem.Add(orderItem);
        }

        public void RemoveOrder(OrderItem orderItem)
        {
            OrderItem.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in OrderItem)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

    }
}
