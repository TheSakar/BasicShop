using System.Collections.Generic;
using BasicShop.Entity;

namespace BasicShop.API.Models
{
    public class OrderAddModel
    {
        

        public Cart Cart { get; set; }

        public Order Order { get; set; }
    }
}