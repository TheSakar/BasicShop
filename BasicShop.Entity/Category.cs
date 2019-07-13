using System.Collections.Generic;
using BasicShop.Core.Entity;

namespace BasicShop.Entity
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}