using System.Collections.Generic;
using BasicShop.Entity;

namespace BasicShop.API.Models
{
    public class OrderAddModel
    {
        public OrderAddModel()
        {
            OrderProducts = new List<OrderProduct>();
            Products = new List<Product>();
        }
        public List<OrderProduct> OrderProducts { get; set; }
        public List<Product> Products { get; set; }
        
        public Order Order { get; set; }
    }
}