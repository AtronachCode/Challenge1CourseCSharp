using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Entitites
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        //Construtores
        public OrderItem() { }
        public OrderItem(Product product,int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        // Métodos

        public double SubTotal()
        {
            return Quantity * Price;
        } 
    }
}
