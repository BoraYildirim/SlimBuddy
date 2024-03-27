using BLL;
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
    public partial class SummaryScreen : Form
    {
        public SummaryScreen(User user)
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
        private void SummaryScreen_Load(object sender, EventArgs e)
        {

            MealSummary mealSummary = new MealSummary();
            List<MealSummary> listMealSummary = new List<MealSummary>();
            // Tüm özetleri al
            foreach (MealSummary summary in mealSummaryService.GetAll())
            {
                // Kullanıcının ID'sine göre özetleri filtrele
                if (summary.UserID == _user.UserID)
                {
                    listMealSummary.Add(summary);
                }
            }
            // Bugünkü tüm öğünleri ekle
            foreach (MealSummary summary2 in listMealSummary)
            {
                Meal meal = mealService.GetById(summary2.MealID);

                // Öğünün oluşturulma tarihi bugünün tarihine eşitse ve "?" değilse
                if (meal.CreationDate.Day == DateTime.Now.Day && meal.MealName!="?")
                {
                    lbMeal.Items.Add(meal);
                }
            }

            // Aynı öğünleri tekrarlamamak için öğünleri tekilleştir
            List<Meal> meals = new List<Meal>();
            foreach (Meal meal in lbMeal.Items)
            {
                if (meals.Contains(meal) == false)
                {
                    meals.Add(meal);
                }
            }

            // Önceki listeyi temizle ve tekilleştirilmiş öğünleri ekleyin
            lbMeal.Items.Clear();
            foreach (Meal meal in meals)
            {
                lbMeal.Items.Add(meal);
            }
        }

        private void lbMeal_DoubleClick(object sender, EventArgs e)
        {
            lbFood.Items.Clear();
            // Seçilen öğünün içindeki yiyecekleri listele
            MealSummary mealSummary = new MealSummary();
            Meal meal = (Meal)lbMeal.SelectedItem;

            foreach (MealSummary summary in mealSummaryService.GetAll())
            {
                if (summary.MealID == meal.MealID)
                {
                    int foodID = summary.FoodID;
                    lbFood.Items.Add(foodService.GetById(foodID));
                }
            }
        }

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            // Seçilen öğünü sil ve bağlı yiyecek listesini temizle
            Meal meal = (Meal)lbMeal.SelectedItem;
            if (lbMeal.SelectedItem != null)
            {
                lbMeal.Items.Remove(lbMeal.SelectedItem);
                mealService.Delete(meal.MealID);
                lbFood.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please Choose Meal !!!");
            }
        }

        private void buttonUpdateMeal_Click(object sender, EventArgs e)
        {
            // Seçilen öğünün bağlı yiyecek listesini temizle
            Meal meal = (Meal)lbMeal.SelectedItem;
            if (lbMeal.SelectedItem != null)
            {          
                lbFood.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please Choose Meal !!!");
            }
        }
    }
}
