using System.Collections.Generic;
using BasicShop.Core.Entity;

namespace BasicShop.Entity
{
    public class User:IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Order> Orders { get; set; }
        
    }
}