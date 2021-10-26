using System;
using Models;
using System.Collections.Generic;


namespace DAL.Repositories
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        DatamanagerCategory dataManager;
        List<Category> listOfCategory;



        public CategoryRepository()
        {
            dataManager = new DatamanagerCategory();
            listOfCategory = GetAllCategory();
        }

        public List<Category> GetAllCategory()
        {
            List<Category> allCa = new List<Category>();
            allCa = dataManager.DerializeFiles();
            return allCa;
        }

        public void Create(string name)
        {
            Category category = new(name);
            listOfCategory.Add(category);
            SaveCategory();

        }
        public void Delete(int i)
        {
            listOfCategory.RemoveAt(i);
            SaveCategory();
        }

        public void SaveCategory()
        {
            dataManager.SerializeFiles(listOfCategory);

        }
        public int GetIndex(string categoryName)
        {
            int i = 0;
            foreach (var category in listOfCategory)
                
            {
                if (categoryName.Equals(category.CategoryName))
                {
                    break;
                }
                i++;
            }
            return i;
        }
        public void Update(int i, Category updatedCategory)
        {
            listOfCategory[i] = updatedCategory;
            SaveCategory();
        }
    }
}
