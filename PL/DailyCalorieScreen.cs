using BLL;
using DAL.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;



namespace PL
{
    public partial class DailyCalorieScreen : Form
    {
        public DailyCalorieScreen(User user)
        {
            InitializeComponent();
            _user = user;
            mealSummaryService = new();
            foodService = new();
            mealService = new();
            userDetailService = new();
            userService = new();



        }

        UserDetailService userDetailService;
        UserService userService;
        MealService mealService;
        FoodService foodService;
        MealSummaryService mealSummaryService;
        User _user;

        private void DailyCalorieScreen_Load(object sender, EventArgs e)
        {
            foreach (ActivityLevel level in Enum.GetValues(typeof(ActivityLevel)))
            {
                comboBoxActivityLevel.Items.Add(level);
            }

            List<MealSummary> mealSummaryList = new List<MealSummary>();

            foreach (MealSummary mealSummary in mealSummaryService.GetAll())
            {
                if (mealSummary.UserID == _user.UserID)
                {
                    mealSummaryList.Add(mealSummary);
                }

            }

            List<int> ints = new List<int>();

            foreach (MealSummary mealSummary in mealSummaryList)
            {
                int mealID;
                mealID = mealSummary.MealID;
                ints.Add(mealID);
            }

            foreach (int i in ints)
            {
                listBoxTodaysMeals.Items.Add(mealService.GetById(i));

            }

            List<Meal> meal2 = new List<Meal>();
            foreach (Meal meal in listBoxTodaysMeals.Items)
            {
                if (meal2.Contains(meal) == false)
                {
                    meal2.Add(meal);
                }
            }

            listBoxTodaysMeals.Items.Clear();

            foreach (Meal meal in meal2)
            {
                if (meal.MealName!="?")
                {
                    listBoxTodaysMeals.Items.Add(meal);
                }
                
            }

            double totalCalorie2 = 0;
            foreach (Meal meal in listBoxTodaysMeals.Items)
            {
                totalCalorie2 += meal.TotalCalorie;
            }

            labelTotal.Text = totalCalorie2.ToString();
        }



        public double CalculateBmr()
        {

            double bmr = 0;
            UserDetail userDetail = userDetailService.GetById(_user.UserID);
            if (userDetail.Gender == Gender.Male)
            {
                bmr = 66.5 + (13.75 * userDetail.Weight) + (5 * userDetail.Height) - (6.77 * userDetail.Age);
                return bmr;
            }
            else
            {
                bmr = 655.1 + (9.56 * userDetail.Weight) + (1.85 * userDetail.Height) - (4.67 * userDetail.Age);
                return bmr;
            }
            return bmr;
        }

        private void comboBoxActivityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            double value;
            if (comboBoxActivityLevel.SelectedIndex == 0)
            {
                value = (CalculateBmr() * 1.0);
               
                labelNeed.Text = Math.Round(value, 2).ToString();  
            }
            if (comboBoxActivityLevel.SelectedIndex == 1)
            {
                
                value = (CalculateBmr() * 1.2);
                
                labelNeed.Text = Math.Round(value, 2).ToString();
            }
            if (comboBoxActivityLevel.SelectedIndex == 2)
            {
                value = (CalculateBmr() * 1.3);
               
                labelNeed.Text = Math.Round(value, 2).ToString();

            }
            if (comboBoxActivityLevel.SelectedIndex == 3)
            {
                value = (CalculateBmr() * 1.4);
               
                labelNeed.Text = Math.Round(value, 2).ToString();

            }
            if (comboBoxActivityLevel.SelectedIndex == 4)
            {
                value = (CalculateBmr() * 1.5);
                
                labelNeed.Text = Math.Round(value, 2).ToString();

            }
        }

        private void labelNeed_Click(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
