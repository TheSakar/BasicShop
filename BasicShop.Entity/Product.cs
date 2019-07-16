using System;
using System.Collections.Generic;
using BasicShop.Core.Entity;

namespace BasicShop.Entity
{
    public class Product : IEntity
    {
        public Product()
        {
            OrderProducts = new List<OrderProduct>();
        }

        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
        

        public string ImgUrl { get; set; }

        public Category Category { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}