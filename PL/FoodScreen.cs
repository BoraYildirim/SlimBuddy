using BLL;
using Models.Concrete;
using Models.Enums;
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
    public partial class FoodScreen : Form
    {
        public FoodScreen(User user)
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


        private void FoodScreen_Load(object sender, EventArgs e)
        {
            foreach (Category category in categoryService.GetAll())
            {
                cmbCategory.Items.Add(category);
            }

            string Portion = "Portion";
            string Quantity = "Quantity";
            string milliliter = "milliliter";

            cmbUnit.Items.Add(Portion);
            cmbUnit.Items.Add(Quantity);
            cmbUnit.Items.Add(milliliter);




            List<MealSummary> mealSummaries = new List<MealSummary>();

            foreach (MealSummary mealSummary in mealSummaryService.GetAll())
            {
                if (mealSummary.UserID == _user.UserID)
                {
                    Meal meal = mealService.GetById(mealSummary.MealID);
                    if (meal.MealName == "?")
                    {
                        mealSummaries.Add(mealSummary);
                    }

                }
            }
            List<int> foodIDs = new List<int>();

            foreach (MealSummary mealSummary in mealSummaries)
            {
                foodIDs.Add(mealSummary.FoodID);
            }

            foreach (int foodID in foodIDs)
            {
                listBoxFoods.Items.Add(foodService.GetById(foodID));
            }



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            Food food = new Food();
            if (cmbUnit.SelectedIndex == 0)
            {
                food.Unit = Models.Enums.Unit.Portion;
            }
            else if (cmbUnit.SelectedIndex == 1)
            {
                food.Unit = Models.Enums.Unit.Quantity;
            }
            else
            {
                food.Unit = Models.Enums.Unit.milliliter;
            }

            if (cmbCategory.SelectedIndex == 0)
            {
                food.CategoryID = 1;
            }
            else if (cmbCategory.SelectedIndex == 1)
            {
                food.CategoryID = 2;
            }
            else if (cmbCategory.SelectedIndex == 2)
            {
                food.CategoryID = 3;
            }
            else if (cmbCategory.SelectedIndex == 3)
            {
                food.CategoryID = 4;
            }
            else if (cmbCategory.SelectedIndex == 4)
            {
                food.CategoryID = 5;
            }
            else if (cmbCategory.SelectedIndex == 5)
            {
                food.CategoryID = 6;
            }
            else if (cmbCategory.SelectedIndex == 6)
            {
                food.CategoryID = 7;
            }
            else if (cmbCategory.SelectedIndex == 7)
            {
                food.CategoryID = 8;
            }
            else if (cmbCategory.SelectedIndex == 8)
            {
                food.CategoryID = 9;
            }
            else
            {
                food.CategoryID = 10;
            }

            food.Name = txtName.Text;
            food.Calorie = double.Parse(txtCalorie.Text);
            food.Image = txtImage.Text;


            foodService.Add(food);

            Meal meal = new Meal();

            meal.MealName = "?";
            meal.Status = Status.Modified;
            meal.TotalCalorie = food.Calorie;
            mealService.Add(meal);

            MealSummary summary = new MealSummary();

            summary.FoodID = food.FoodID;
            summary.MealID = meal.MealID;
            summary.UserID = _user.UserID;

            mealSummaryService.Add(summary);





        }

        private void listBoxFoods_DoubleClick(object sender, EventArgs e)
        {
            Food food = (Food)listBoxFoods.SelectedItem;
            txtName.Text = food.Name;
            txtCalorie.Text = food.Calorie.ToString();
            txtImage.Text = food.Image;



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Food food = (Food)listBoxFoods.SelectedItem;

            if (cmbUnit.SelectedIndex == 0)
            {
                food.Unit = Models.Enums.Unit.Portion;
            }
            else if (cmbUnit.SelectedIndex == 1)
            {
                food.Unit = Models.Enums.Unit.Quantity;
            }
            else
            {
                food.Unit = Models.Enums.Unit.milliliter;
            }

            if (cmbCategory.SelectedIndex == 0)
            {
                food.CategoryID = 1;
            }
            else if (cmbCategory.SelectedIndex == 1)
            {
                food.CategoryID = 2;
            }
            else if (cmbCategory.SelectedIndex == 2)
            {
                food.CategoryID = 3;
            }
            else if (cmbCategory.SelectedIndex == 3)
            {
                food.CategoryID = 4;
            }
            else if (cmbCategory.SelectedIndex == 4)
            {
                food.CategoryID = 5;
            }
            else if (cmbCategory.SelectedIndex == 5)
            {
                food.CategoryID = 6;
            }
            else if (cmbCategory.SelectedIndex == 6)
            {
                food.CategoryID = 7;
            }
            else if (cmbCategory.SelectedIndex == 7)
            {
                food.CategoryID = 8;
            }
            else if (cmbCategory.SelectedIndex == 8)
            {
                food.CategoryID = 9;
            }
            else
            {
                food.CategoryID = 10;
            }

            food.Name = txtName.Text;
            food.Calorie = double.Parse(txtCalorie.Text);
            food.Image = txtImage.Text;

            foodService.Update(food);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Food food = (Food)listBoxFoods.SelectedItem;
            foodService.Delete(food.FoodID);            
        }
    }
}
