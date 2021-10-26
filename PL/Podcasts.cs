using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
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
            categoryController.createCategory("Historia");
           List<Category> categoryList = categoryController.GetAllCategory();
            foreach(var item in categoryList)
            {
                categoryBox.Items.Add(item.CategoryName);
            }
            

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
