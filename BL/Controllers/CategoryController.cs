using System;
using System.Collections.Generic;
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
        public void createCategory(string name)
        {
            Category newCategory = new Category(name);
            categoryRepository.Create(newCategory);
        }
        public List<Category> GetAllCategory()
        {
            return categoryRepository.GetAll();
        }
        public void deleteCategory(string category)
        {
            int i = categoryRepository.GetIndexOfName(category);
            categoryRepository.Delete(i);
        }

        public void updatCategory(Category oldCat, string newCategoryName)

        {
            int i = categoryRepository.GetIndexOfName(oldCat.CategoryName);
            Category newCategory = new Category(newCategoryName);
            categoryRepository.Update(i, newCategory);
        }
    }
}
