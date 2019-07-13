using System.Collections.Generic;
using BasicShop.Business.Abstract;
using BasicShop.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BasicShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]        
        public ActionResult Get()
        {
           return Ok(_productService.GetAll());
        }

        [HttpGet("{categoryId}")]
        public ActionResult Get(int categoryId)
        {
            return Ok(_productService.GetByCategoryId(categoryId));
        }
        
        
    }
}