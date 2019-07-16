using BasicShop.Business.Abstract;
using BasicShop.DataAccess.Abstract;
using BasicShop.Entity;

namespace BasicShop.Business.Concrete
{
    public class OrderProductManager:IOrderProductService
    {
        private readonly IOrderProductDal _orderProductDal;

        public OrderProductManager(IOrderProductDal orderProductDal)
        {
            _orderProductDal = orderProductDal;
        }

        public void Add(OrderProduct orderProduct)
        {
            _orderProductDal.Add(orderProduct);
        }
    }
}