using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao9_ExFixacao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public Order Order { get; set; }

        public Client()
        {
        }

        public Client(string name, string address, DateTime birthDate)
        {
            Name = name;
            Address = address;
            BirthDate = birthDate;
        }

        public void InsertClientOrder(Order order)
        {
            Order = order;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLIENT INFO");
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Birth Date: " + BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("Address: " + Address);
            sb.AppendLine();
            sb.AppendLine("ORDER INFO");
            sb.AppendLine("Order moment: " + Order.Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status: " + Order.Status.ToString());
            sb.AppendLine("Products: ");
            foreach(OrderItem ord in Order.OrderItem)
            {
                sb.AppendLine(ord.Product.Name + ", Quantity: " + ord.Quantity + ", Subtotal: $" + ord.SubTotal().ToString("F2",CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Total: $" + Order.Total());
            return sb.ToString();
        }

    }
}
