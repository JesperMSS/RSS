using System;
using DAL;
using Models;
using DAL.Repositories;

namespace BL.Controllers
{
    public class CategoryController
    {
        ICategoryRepository<Category> categoryRepository;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }
        public void createCategory()
        {

        }
    }
}
