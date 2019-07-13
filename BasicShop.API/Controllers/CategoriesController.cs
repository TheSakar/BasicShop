using System.Collections.Generic;
using BasicShop.Business.Abstract;
using BasicShop.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BasicShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_categoryService.GetAll());
        }
    }
}