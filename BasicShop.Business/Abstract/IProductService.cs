using System.Collections.Generic;
using BasicShop.Entity;

namespace BasicShop.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetByCategoryId(int categoryId);

        Product GetById(int productId);
    }
}