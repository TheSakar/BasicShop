using BasicShop.Business.Abstract;
using BasicShop.DataAccess.Abstract;
using BasicShop.Entity;

namespace BasicShop.Business.Concrete
{
    public class OrderManager:IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }
    }
}