using System.Collections.Generic;
using BasicShop.Entity;

namespace BasicShop.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}