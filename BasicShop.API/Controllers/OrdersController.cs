using BasicShop.API.Models;
using BasicShop.Business.Abstract;
using BasicShop.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BasicShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IOrderProductService _orderProductService;

        public OrdersController(IOrderService orderService, IOrderProductService orderProductService)
        {
            _orderService = orderService;
            _orderProductService = orderProductService;
        }

        [HttpPost]
        public IActionResult Post(OrderAddModel orderAddModel)
        {
            _orderService.Add(orderAddModel.Order);

            for (int i = 0; i < orderAddModel.Products.Count; i++)
            {
                var orderProduct = new OrderProduct();
                orderProduct.Order = orderAddModel.Order;
                orderProduct.Product = orderAddModel.Products[i];
                _orderProductService.Add(orderProduct);
            }


            return NoContent();
        }
    }
}