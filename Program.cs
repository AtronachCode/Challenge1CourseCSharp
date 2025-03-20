using System;
using System.Globalization;
using System.Collections.Generic;
using Challenge.Entitites;
using Challenge.Entitites.Enums;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do cliente");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento(DD/MM/YYYY): ");
            DateTime birthDate= DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Console.WriteLine();

            DateTime date = DateTime.Now;

            Console.Write("Status do pedido: ");
            OrderStatus status = Enum.Parse < OrderStatus > (Console.ReadLine());

            Order order = new Order(date, status, client);

            Console.WriteLine();
            Console.Write("Quantos produtos deseja: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Item{i}");
                Console.Write("Nome do Produto: ");
                string productName = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem items = new OrderItem(product, quantity, productPrice);
                order.AddItem(items);
                
            }
            Console.WriteLine(order);
        }
    }
}