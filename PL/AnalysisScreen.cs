using BLL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Models.Concrete;
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
    public partial class AnalysisScreen : Form
    {
        public AnalysisScreen(User user)
        {
            InitializeComponent();
            categoryService = new();
            foodService = new();
            _user = user;
            mealService = new();
            mealSummaryService = new();
            userService = new();
        }
        UserService userService;
        MealSummaryService mealSummaryService;
        MealService mealService;
        CategoryService categoryService;
        FoodService foodService;
        User _user;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AnalysisScreen_Load(object sender, EventArgs e)
        {


            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("MealName", "MealName");
            dataGridView1.Columns.Add("TotalCalorie", "TotalCalorie");

            List<User> Uss = userService.GetAll();
            List<MealSummary> mSs = mealSummaryService.GetAll();
            List<Meal> ms = mealService.GetAll();

            foreach (var item in userService.MealOfAllDaily(Uss, mSs, ms))
            {
                dynamic row = item;
                dataGridView1.Rows.Add(row.Email, row.MealName, row.TotalCalorie);
            }




            dgvUserWeek.Columns.Add("Email", "Email");
            dgvUserWeek.Columns.Add("MealName", "MealName");
            dgvUserWeek.Columns.Add("TotalCalorie", "TotalCalorie");

            List<User> Uss2 = userService.GetAll();
            List<MealSummary> mSs2 = mealSummaryService.GetAll();
            List<Meal> ms2 = mealService.GetAll();


            foreach (var item in userService.MealOfAllWeekly(Uss2, mSs2, ms2))
            {
                dynamic row = item;
                dgvUserWeek.Rows.Add(row.Email, row.MealName, row.TotalCalorie);
            }


            dgvThisUserDaily.Columns.Add("Email", "Email");
            dgvThisUserDaily.Columns.Add("MealName", "MealName");
            dgvThisUserDaily.Columns.Add("TotalCalorie", "TotalCalorie");

            List<User> Uss3 = new List<User>();
            Uss3.Add(_user);
            List<MealSummary> mSs3 = mealSummaryService.GetAll();
            List<Meal> ms3 = mealService.GetAll();

            foreach (var item in userService.MealOfAllDaily(Uss3, mSs3, ms3))
            {
                dynamic row = item;
                dgvThisUserDaily.Rows.Add(row.Email, row.MealName, row.TotalCalorie);
            }



            dgvThisUserWeek.Columns.Add("Email", "Email");
            dgvThisUserWeek.Columns.Add("MealName", "MealName");
            dgvThisUserWeek.Columns.Add("TotalCalorie", "TotalCalorie");

            List<User> Uss4 = new List<User>();
            Uss4.Add(_user);
            List<MealSummary> mSs4 = mealSummaryService.GetAll();
            List<Meal> ms4 = mealService.GetAll();

            foreach (var item in userService.MealOfAllWeekly(Uss4, mSs4, ms4))
            {
                dynamic row = item;
                dgvThisUserWeek.Rows.Add(row.Email, row.MealName, row.TotalCalorie);
            }



            List<Meal> mealList = new List<Meal>();

            foreach (Meal meal in mealService.GetAll())
            {
                if (meal.MealName == "?")
                {
                    mealList.Add(meal);
                }

            }

            List<MealSummary> allSummaries = new List<MealSummary>();
            allSummaries = mealSummaryService.GetAll();
            for (int i = 0; i < mealList.Count; i++)
            {
                for (int j = 0; j < allSummaries.Count; j++)
                {
                    if (mealList[i].MealID == allSummaries[j].MealID)
                    {
                        allSummaries.RemoveAt(j);
                    }

                }
            }


            List<MealSummary> mealSummaries = new List<MealSummary>();
            foreach (MealSummary mealSummary in allSummaries)
            {
                if (mealSummary.UserID == _user.UserID)
                {
                    mealSummaries.Add(mealSummary);
                }
            }
            List<int> foodIdList = new List<int>();
            foreach (MealSummary mealSummary1 in mealSummaries)
            {
                foodIdList.Add(mealSummary1.FoodID);
            }

            List<Food> TodayFoods = new List<Food>();

            foreach (int i in foodIdList)
            {
                Food food = foodService.GetById(i);
                TodayFoods.Add(food);
            }

            foreach (Food food in TodayFoods)
            {

            listBox1.Items.Add(food);
            }

        }

        private void rdoWeekly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoDaily_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

            
        }
    }
}
