using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BL.Controllers;
using Models;
namespace FiGUI
{
    public partial class Podcasts : Form
    {
        FeedController feedController;
        CategoryController categoryController;

        public Podcasts()
        {
            feedController = new FeedController();
            categoryController = new CategoryController();
            InitializeComponent();
            fillCategory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FreqCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctgNewBTN_Click(object sender, EventArgs e)
        {
            categoryController.createCategory("Cola");
            categoryController.createCategory("Pepsi");
            categoryController.createCategory("Fanta");
            categoryController.createCategory("Zingo");
            categoryController.createCategory("Vatten");
            fillCategory();
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            
        }
        private void fillCategory()
        {
            categoryBox.Items.Clear();
            List<Category> categoryList = categoryController.GetAllCategory();
            foreach (var item in categoryList)
            {
                categoryBox.Items.Add(item.CategoryName);
                CategoryCombo.Items.Add(item.CategoryName);
            }
        }

        private void ctgDeleteBTN_Click(object sender, EventArgs e)
        {
            string categoryToDelete = categoryBox.GetItemText(categoryBox.SelectedItem);
            categoryController.deleteCategory(categoryToDelete);
            fillCategory();
        }
        private void fillCategory()
        {
            categoryBox.Items.Clear();
            List<Category> categoryList = categoryController.GetAllCategory();
            foreach (var item in categoryList)
            {
                categoryBox.Items.Add(item.CategoryName);
                CategoryCombo.Items.Add(item.CategoryName);
            }
        }

        private void ctgDeleteBTN_Click(object sender, EventArgs e)
        {
            string categoryToDelete = categoryBox.GetItemText(categoryBox.SelectedItem);
            categoryController.deleteCategory(categoryToDelete);
            fillCategory();
        }
    }
}
