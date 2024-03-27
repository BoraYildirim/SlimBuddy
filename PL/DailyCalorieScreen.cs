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
            // Fark etiketi varsayılan olarak gizlenir.
            lblDifference.Visible = false;

            // Aktivite seviyesi seçim kutusuna tüm enum değerleri eklenir.
            foreach (ActivityLevel level in Enum.GetValues(typeof(ActivityLevel)))
            {
                comboBoxActivityLevel.Items.Add(level);
            }

            // Kullanıcının günlük öğünlerinin listesi oluşturulur.
            List<MealSummary> mealSummaryList = new List<MealSummary>();

            foreach (MealSummary mealSummary in mealSummaryService.GetAll())
            {
                if (mealSummary.UserID == _user.UserID)
                {
                    mealSummaryList.Add(mealSummary);
                }
            }

            // Günlük öğünlerin ID'leri alınır.
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

            // Tekrar eden öğünler filtrelenir.
            List<Meal> meal2 = new List<Meal>();

            foreach (Meal meal in listBoxTodaysMeals.Items)
            {
                if (meal2.Contains(meal) == false)
                {
                    meal2.Add(meal);
                }
            }

            // Listbox temizlenir ve "?" olmayan öğünler tekrar eklenir.
            listBoxTodaysMeals.Items.Clear();

            foreach (Meal meal in meal2)
            {
                if (meal.MealName!="?")
                {
                    listBoxTodaysMeals.Items.Add(meal);
                }       
            }

            // Tüm öğünlerin toplam kalorisi hesaplanır.
            double totalCalorie2 = 0;
            foreach (Meal meal in listBoxTodaysMeals.Items)
            {
                totalCalorie2 += meal.TotalCalorie;
            }
            // Toplam kalori etiketine yazdırılır.
            labelTotal.Text = totalCalorie2.ToString();
            totalCalorie3 = totalCalorie2; // Toplam kalori değeri başka bir metoda aktarılır.
        }

        double totalCalorie3;
        /// <summary>
        ///  Temel metabolizma hızı (BMR) hesaplaması yapılır.
        /// </summary>
        /// <returns></returns>
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

        // Aktivite seviyesi değiştiğinde çağrılan olay işleyicisi.
        private void comboBoxActivityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            double value=0;
            // Seçilen aktivite seviyesine göre ihtiyaç olan kalori hesaplanır.
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

            // Kalori farkı hesaplanır ve ekrana yazdırılır.
            double KaloriFarki =totalCalorie3 - (double)value;
            if (KaloriFarki>0)
            {
                lblDifference.BackColor = Color.Red;
                lblDifference.Text = "Difference = " + Math.Round(KaloriFarki,2).ToString()+ " " + " You are gaining weight ";
                lblDifference.Visible= true;
            }
            if (KaloriFarki==0)
            {
                lblDifference.BackColor = Color.Blue;
                lblDifference.Text = "Balanced";
                lblDifference.Visible = true;
            }
            if (KaloriFarki<0)
            {
                lblDifference.BackColor = Color.Green;
                lblDifference.Text = "Difference = "+ Math.Round(KaloriFarki, 2).ToString() + " " + " you are losing weight ";
                lblDifference.Visible = true;
            }          
        }
    }
}
