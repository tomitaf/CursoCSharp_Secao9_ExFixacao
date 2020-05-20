using System;
using Secao9_ExFixacao.Entities;
using Secao9_ExFixacao.Entities.Enums;

namespace Secao9_ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client information: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Number of orders: ");
            int numberOrder = int.Parse(Console.ReadLine());
            Client c = new Client(name, address, birthDate);
            Console.Write("Order status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order ord = new Order(DateTime.Now, status);
            for (int i = 0; i < numberOrder; i++)
            {
                Console.WriteLine("Enter product #" + (i+1) + " information:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Price (unit): ");
                double prodPrice = double.Parse(Console.ReadLine());
                Product p = new Product(prodName, prodPrice);
                Console.Write("Quantity: ");
                int quantProd = int.Parse(Console.ReadLine());
                OrderItem ordItem = new OrderItem(quantProd,p);
                ord.AddOrder(ordItem);
            }
            c.InsertClientOrder(ord);
            Console.WriteLine(c);
        }
    }
}
