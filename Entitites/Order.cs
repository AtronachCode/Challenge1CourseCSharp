using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Challenge.Entitites.Enums;


namespace Challenge.Entitites
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        //Construtores

        public Order() { }
        public Order(DateTime date, OrderStatus status,Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        //Métodos

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }
        public double Total()
        {
            double sum = 0f;
            foreach(OrderItem item in OrderItem)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Console.Clear();
            sb.AppendLine("Resumo do Pedido");
            sb.AppendLine($"Data do Pedido: {Date}");
            sb.AppendLine($"Status do Pedido: {Status}");
            sb.AppendLine("Cliente: ");
            sb.AppendLine($"Nome: {Client.Name}");
            sb.AppendLine($"Email: {Client.Email}");
            sb.AppendLine($"Data Nascimento: {Client.BirthDate.ToString("dd/MM/yyyy")}");
            sb.AppendLine("Pedidos: ");
            foreach(OrderItem item in OrderItem)
            {
                sb.AppendLine($"Nome do Produto: {item.Product.Name}");
                sb.AppendLine($"Preço: {item.Price.ToString("F2")}");
                sb.AppendLine($"Quantidade: {item.Quantity.ToString()}");
            }
            sb.AppendLine($"Valor Total: {Total().ToString("F2",CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
