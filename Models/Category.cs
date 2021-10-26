using System;
namespace Models
{
    public class Category
    {
        public string CategoryName { get; set;}

        public Category(string cName)
        {
            CategoryName = cName;
        }
    }
}
