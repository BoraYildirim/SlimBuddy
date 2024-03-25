using BLL;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using Models.Enums;
using PL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class MealScreen : Form
    {
        public MealScreen(User user)
        {
            InitializeComponent();
            categoryService = new();
            foodService = new();
            _user = user;
            mealService = new();
            mealSummaryService = new();
        }
        MealSummaryService mealSummaryService;
        MealService mealService;
        CategoryService categoryService;
        FoodService foodService;
        User _user;

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonBreakfast_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MealScreen_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = categoryService.GetAll();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryName";



        }

        private void radioButtonLunch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStripCaregories_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = comboBoxCategory.SelectedItem as Category;

            lbFoods.DataSource = foodService.GetFoodByCategoryName(category.CategoryName);

            lbFoods.DisplayMember = "Name Calorie";


        }

        private void lbFoods_Click(object sender, EventArgs e)
        {
            Food food = lbFoods.SelectedItem as Food;

            string strPath = "C:\\Users\\boray\\Desktop\\SlimBuddy\\DAL" + food.Image;

            pictureBox1.ImageLocation = strPath;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbFoods_DoubleClick(object sender, EventArgs e)
        {
            lbMeal.Items.Add(lbFoods.SelectedItem as Food);
        }

        private void lbFoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveMeal_Click(object sender, EventArgs e)
        {


            if (lbMeal.Items != null && (radioButtonBreakfast.Checked || radioButtonDinner.Checked || radioButtonLunch.Checked || radioButtonSnack.Checked))
            {
                Meal meal = new Meal();

                if (radioButtonBreakfast.Checked)
                {
                    meal.MealName = "Breakfast";
                }
                else if (radioButtonDinner.Checked)
                {
                    meal.MealName = "Dinner";
                }
                else if (radioButtonLunch.Checked)
                {
                    meal.MealName = "Lunch";
                }
                else
                {
                    meal.MealName = "Snack";
                }
                double calorie = 0;
                foreach (Food fo in lbMeal.Items)
                {
                    calorie += fo.Calorie;
                }
                meal.TotalCalorie = calorie;
                mealService.Add(meal);



                foreach (Food foo in lbMeal.Items)
                {
                    MealSummary summary = new MealSummary();
                    summary.UserID = _user.UserID;
                    summary.MealID = meal.MealID;
                    summary.FoodID = foo.FoodID;
                    mealSummaryService.Add(summary);
                }

            }
            else
            {
                MessageBox.Show("Meal seems empty or radio buttons empty");
            }

        }

        private void lbMeal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearchFood_TextChanged(object sender, EventArgs e)
        {
            



        }
    }
}
