using System.Collections.Generic;
using BasicShop.Core.Entity;

namespace BasicShop.Entity
{
    public class Order : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }


        public List<OrderProduct> OrderProducts { get; set; }

        public Order()
        {

            OrderProducts = new List<OrderProduct>();
        }
    }
}