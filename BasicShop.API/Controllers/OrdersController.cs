using BasicShop.API.Models;
using BasicShop.Business.Abstract;
using BasicShop.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BasicShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;

        public OrdersController(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Post(OrderAddModel orderAddModel)
        {
            
            
            
            for (int i = 0; i < orderAddModel.Products.Count; i++)
            {
                
                var orderProduct = new OrderProduct();
                orderProduct.Product = _productService.GetById(orderAddModel.Products[i].Id);
                orderProduct.Order = orderAddModel.Order;

                orderAddModel.Order.OrderProducts.Add(orderProduct);
            }

            _orderService.Add(orderAddModel.Order);


            return NoContent();
        }
    }
}