using BasicShop.Core.Entity;

namespace BasicShop.Entity
{
    public class OrderProduct : IEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}