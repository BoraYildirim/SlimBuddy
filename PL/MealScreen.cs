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
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
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
        private void radioButtonBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabelMealName(); // Yemek adı etiketini değiştirme işlevini çağır
        }

        private void MealScreen_Load(object sender, EventArgs e)
        {   
            // Kategori combobox'ını veritabanından alınan kategori listesiyle doldur       
            comboBoxCategory.DataSource = categoryService.GetAll();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryName";
        }

        private void radioButtonLunch_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabelMealName(); // Yemek adı etiketini değiştirme işlevini çağır
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen kategoriyi al
            Category category = comboBoxCategory.SelectedItem as Category;
            // Listbox'ı seçilen kategoriye göre doldur
            lbFoods.DataSource = foodService.GetFoodByCategoryName(category.CategoryName);
            // Listbox'ta gösterilecek özellikleri belirt
            lbFoods.DisplayMember = "Name Calorie";
        }

        private void lbFoods_Click(object sender, EventArgs e)
        {

            // lbFoods listesinden seçili olan nesneyi al
            var food = lbFoods.SelectedItem as Food;

            if (food != null)
            {
                // Food.Name'i boşluklara göre böl
                var parts = food.Name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // İlk kelimenin ilk harfini büyük yap, geri kalanını küçük yap
                if (parts.Length > 0)
                {
                    parts[0] = char.ToUpper(parts[0][0]) + parts[0].Substring(1).ToLower();
                }

                // İkinci kelime ve sonrasını küçük harfe çevir
                for (int i = 1; i < parts.Length; i++)
                {
                    parts[i] = parts[i].ToLower();
                }

                // Kısımları birleştirerek boşluksuz bir string oluştur
                var resourceName = string.Concat(parts);

                // ResourceManager ile kaynağı bul
                var resourceManager = new ResourceManager("PL.Properties.Resources", Assembly.GetExecutingAssembly());

                try
                {
                    // Kaynağın adını kullanarak o kaynağı al ve PictureBox'a ata
                    var image = (Bitmap)resourceManager.GetObject(resourceName, CultureInfo.InvariantCulture);
                    pictureBox1.Image = image;
                }
                catch (Exception ex)
                {
                    // Kaynak bulunamazsa veya başka bir hata olursa
                    Console.WriteLine("Kaynak bulunamadı veya bir hata oluştu: " + ex.Message);
                    // Hata işleme veya yedek planınızı burada uygulayabilirsiniz.
                }
            }
        }
         
        private void lbFoods_DoubleClick(object sender, EventArgs e)
        {
            // Listbox'ta seçilen öğe ve seçili öğün kontrol edilir
            if (lbMeal.Items != null && (radioButtonBreakfast.Checked || radioButtonDinner.Checked || radioButtonLunch.Checked || radioButtonSnack.Checked))
            {
                // Seçilen yiyeceği öğün listesine ekleyin ve toplam kaloriyi güncelleyin
                lbMeal.Items.Add(lbFoods.SelectedItem as Food);
                UpdateTotalCalorie();
            }
            else
            {
                MessageBox.Show("Please Choose Meal !!!");
            }
        }
     
        private void buttonSaveMeal_Click(object sender, EventArgs e)
        {
            // Öğün listesinin boş olup olmadığı kontrol edilir
            if (lbMeal.Items.Count == 0)
            {
                MessageBox.Show("Please choose food !!!");
            }
            else
            {
                Meal meal = new Meal();

                // Hangi öğün türünün seçildiğine bağlı olarak öğün adı atanır
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
                // Öğünde bulunan yiyeceklerin toplam kalorisi hesaplanır
                double calorie = 0;
                foreach (Food fo in lbMeal.Items)
                {
                    calorie += fo.Calorie;
                }
                meal.TotalCalorie = calorie;

                // Yeni öğün veritabanına eklenir
                mealService.Add(meal);

                // Her bir yiyecek için bir özet oluşturulur ve veritabanına eklenir
                foreach (Food foo in lbMeal.Items)
                {
                    MealSummary summary = new MealSummary();
                    summary.UserID = _user.UserID;
                    summary.MealID = meal.MealID;
                    summary.FoodID = foo.FoodID;
                    mealSummaryService.Add(summary);
                }
                MessageBox.Show("Congratulations, your meal was successfully recorded.");
                lbMeal.Items.Clear();
                UpdateTotalCalorie();
                labelMealName.Text = string.Empty;
                labelMealName.Refresh();
                radioButtonBreakfast.Checked = false;
                radioButtonDinner.Checked = false;
                radioButtonLunch.Checked = false;
                radioButtonSnack.Checked = false;            
            }
        }

        private void textBoxSearchFood_TextChanged(object sender, EventArgs e)
        {
            // Arama kutusundaki metne göre yiyecekleri al
            List<Food> food = foodService.GetFoodWithWord(textBoxSearchFood.Text);

            lbFoods.DataSource = food; // Yiyecekleri liste kutusuna veri kaynağı olarak ata

            lbFoods.DisplayMember = "Name Calorie";  // Listbox'ta gösterilecek özellikleri belirt
        }

        private void lbMeal_DoubleClick(object sender, EventArgs e)
        {
            // Eğer öğün listesi boş değilse seçilen öğeyi kaldır ve toplam kaloriyi güncelle
            if (lbMeal.Items != null)
            {
                lbMeal.Items.Remove(lbMeal.SelectedItem);
                UpdateTotalCalorie();
            }
        }

        private void UpdateTotalCalorie()
        {
            double totalCalorie = 0;

            foreach (Food item in lbMeal.Items)// Her yiyeceğin kalorisini topla
            {
                totalCalorie += item.Calorie;
            }

            labelTotalCalorieValue.Text = totalCalorie.ToString(); // Toplam kaloriyi ekrana yazdır
        }

        private void ChangeLabelMealName()
        {
            string name = string.Empty;
            // Öğün adını belirle
            if (radioButtonBreakfast.Checked)
            {
                name = "Breakfast";
            }
            else if (radioButtonDinner.Checked)
            {
                name = "Dinner";
            }
            else if (radioButtonLunch.Checked)
            {
                name = "Lunch";
            }
            else
            {
                name = "Snack";
            }
            labelMealName.Text = name; // Etiketin metnini güncelle
        }

        private void radioButtonDinner_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabelMealName(); // Öğün adını değiştir
        }

        private void radioButtonSnack_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabelMealName(); // Öğün adını değiştir
        }
    }
}
