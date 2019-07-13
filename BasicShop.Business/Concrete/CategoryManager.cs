using System.Collections.Generic;
using BasicShop.Business.Abstract;
using BasicShop.DataAccess.Abstract;
using BasicShop.Entity;

namespace BasicShop.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}