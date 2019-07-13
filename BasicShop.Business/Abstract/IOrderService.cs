using BasicShop.Entity;

namespace BasicShop.Business.Abstract
{
    public interface IOrderService
    {
        void Add(Order order);
    }
}