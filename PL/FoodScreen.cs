using BLL;
using Models.Concrete;
using Models.Enums;
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
using System.Text.RegularExpressions;
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
            // Kategori seçim kutusuna tüm kategorileri yükle
            cmbCategory.DataSource = categoryService.GetAll();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedItem = null;

            string Portion = "Portion";
            string Quantity = "Quantity";
            string milliliter = "milliliter";

            cmbUnit.Items.Add(Portion);
            cmbUnit.Items.Add(Quantity);
            cmbUnit.Items.Add(milliliter);

            // Belirsiz bir öğün (isimsiz) içeren özetleri al
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
            // Her özetin besin kimlik numarasını al ve listeye ekle
            List<int> foodIDs = new List<int>();

            foreach (MealSummary mealSummary in mealSummaries)
            {
                foodIDs.Add(mealSummary.FoodID);
            }

            // Her besin kimliği için besini al ve listboxa ekle
            foreach (int foodID in foodIDs)
            {
                listBoxFoods.Items.Add(foodService.GetById(foodID));
            }
        }
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxFoods.SelectedItem != null)
            {
                MessageBox.Show("deselect from the list to add product");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtName.Text))// Ad alanı boşsa uyarı göster
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (foodService.CheckEntries(txtName.Text)) // Girişlerin benzersizliğini kontrol et
            {
                MessageBox.Show("the food name already exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ad alanında sadece harfler (Türkçe harfler de dahil) ve maksimum 4 boşluk olmalıdır
            int spaceCount = txtName.Text.Count(c => c == ' ');
            bool isValidTurkishLettersAndSpaces = Regex.IsMatch(txtName.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces || spaceCount > 4)
            {
                MessageBox.Show("Name field must contain only letters (including Turkish letters) and a maximum of 4 spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kalori sayısal bir değer olmalı ve 0 ile 5000 arasında olmalıdır
            int calorieValue;
            bool isNumeric = int.TryParse(txtCalorie.Text, out calorieValue);
            if (!isNumeric || calorieValue < 0 || calorieValue > 5000)
            {
                MessageBox.Show("Calorie must be a numeric value between 0 and 5000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Birim seçilmemişse uyarı göster
            if (cmbUnit.SelectedItem == null)
            {
                MessageBox.Show("You must select a unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kategori seçilmemişse uyarı göster
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("You must select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Yeni bir besin oluştur
            Food food = new Food();
            food.Unit = (Unit)cmbUnit.SelectedIndex+1;
            food.CategoryID = cmbCategory.SelectedIndex+1;
            food.Name = txtName.Text;
            food.Calorie = double.Parse(txtCalorie.Text);
            food.Image = string.Empty;

            // Kayıt için belirtilen dizin oluşturulur
            string resourcesFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Resources");

            // Klasör yoksa oluştur
            if (!Directory.Exists(resourcesFolder))
            {
                Directory.CreateDirectory(resourcesFolder);
            }

            // Resim varsa kaydet
            string savedFilePath = "";
            if (pictureBox1.Tag != null)
            {
                // Kullanıcının seçtiği orijinal dosyanın adını al
                string originalFileName = Path.GetFileName(pictureBox1.Tag.ToString());

                // Kaydetmek için tam yol oluştur
                string fullPath = Path.Combine(resourcesFolder, originalFileName);

                // Dosya zaten varsa, bir numara ekleyerek benzersiz bir isim oluştur
                string directory = Path.GetDirectoryName(fullPath);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullPath);
                string extension = Path.GetExtension(fullPath);
                int count = 1;
                while (File.Exists(fullPath))
                {
                    string tempFileName = $"{fileNameWithoutExtension}({count++}){extension}";
                    fullPath = Path.Combine(directory, tempFileName);
                }

                // Resmi belirlenen yola kaydet
                pictureBox1.Image.Save(fullPath);

                // Kaydedilen dosyanın tam yolunu sakla
                savedFilePath = fullPath;
            }

            // Kaydedilen dosyanın yolunu food.Image ile ilişkilendir
            // Burada, dosyanın tam yolu yerine, belki de bir göreceli yol veya başka bir tanımlayıcı kullanmak isteyebilirsiniz.
            food.Image = savedFilePath;
            foodService.Add(food);

            Meal meal = new Meal(); // Yeni bir öğün oluşturulur ve varsayılan değerler atanır

            meal.MealName = "?";
            meal.Status = Status.Modified;
            meal.TotalCalorie = food.Calorie;
            mealService.Add(meal); // Oluşturulan öğün veritabanına eklenir

            MealSummary summary = new MealSummary();  // Yeni bir özet oluşturulur ve verileri atanır

            summary.FoodID = food.FoodID;
            summary.MealID = meal.MealID;
            summary.UserID = _user.UserID;

            mealSummaryService.Add(summary); // Oluşturulan özet veritabanına eklenir

            MessageBox.Show("Validation succeeded. Saving data...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBoxFoods.Items.Add(food);
            ClearTextBox();
            ClearComboBoxSelections();
            pictureBox1.Image = null;
        }

        public void ClearTextBox() //textbox temizleme işlemi yapar
        {
            txtName.Text = string.Empty;
            txtCalorie.Text = string.Empty;
            txtImage.Text = string.Empty;
        }

        private void ClearComboBoxSelections()  //combobox seçili itemı sıfırlar
        {
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedItem = null;
                }
            }
        }

        private void listBoxFoods_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxFoods.SelectedItem != null)
            {
                // Seçilen öğe bir besindir, bu nedenle Food türüne dönüştürülür
                Food food = (Food)listBoxFoods.SelectedItem;

                // Giriş alanlarına seçilen besinin bilgileri yerleştirilir
                txtName.Text = food.Name;
                txtCalorie.Text = food.Calorie.ToString();
                txtImage.Text = food.Image;

                int number =0;
                if(food.Unit==Unit.Portion) 
                {
                    number = 0;
                }
                if (food.Unit == Unit.Quantity)
                {
                    number = 1;
                }
                if (food.Unit == Unit.milliliter)
                {
                    number = 2;
                }
                cmbUnit.SelectedIndex = number;

                cmbCategory.SelectedItem = categoryService.GetById(food.CategoryID);              
            }
        }

        /// <summary>
        /// food update işlemi yapan metod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (listBoxFoods.SelectedItem == null)
            {
                MessageBox.Show("Please Choose Food !!!");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int spaceCount = txtName.Text.Count(c => c == ' ');
            bool isValidTurkishLettersAndSpaces = Regex.IsMatch(txtName.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces || spaceCount > 4)
            {
                MessageBox.Show("Name field must contain only letters (including Turkish letters) and a maximum of 2 spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int calorieValue;
            bool isNumeric = int.TryParse(txtCalorie.Text, out calorieValue);
            if (!isNumeric || calorieValue < 0 || calorieValue > 5000)
            {
                MessageBox.Show("Calorie must be a numeric value between 0 and 5000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbUnit.SelectedItem == null)
            {
                MessageBox.Show("You must select a unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("You must select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Food food = (Food)listBoxFoods.SelectedItem; //seçili foodu alır

            food.Unit = (Unit)cmbUnit.SelectedIndex + 1;
            food.CategoryID = cmbCategory.SelectedIndex+1;           
            food.Name = txtName.Text;
            food.Calorie = double.Parse(txtCalorie.Text);
            food.Image = txtImage.Text;           
            foodService.Update(food); //update yapar

            int selectedIndex = listBoxFoods.SelectedIndex;
            listBoxFoods.Items.Remove(food);
            listBoxFoods.Items.Insert(selectedIndex, food);

            MessageBox.Show("Update succeeded. Saving data...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBox();
            ClearComboBoxSelections();
        }

        private void FoodScreen_MouseClick(object sender, MouseEventArgs e) //formda bir yer tıklandığında listedeki seçili
        {                                                                   //itemı kaldırır
            listBoxFoods.ClearSelected(); 
        }

        /// <summary>
        /// food silme işlemi yapan metod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleted_Click(object sender, EventArgs e)
        {
            if (listBoxFoods.SelectedItem == null)
            {
                MessageBox.Show("Please Choose Food !!!");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int spaceCount = txtName.Text.Count(c => c == ' ');
            bool isValidTurkishLettersAndSpaces = Regex.IsMatch(txtName.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces || spaceCount > 4)
            {
                MessageBox.Show("Name field must contain only letters (including Turkish letters) and a maximum of 2 spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int calorieValue;
            bool isNumeric = int.TryParse(txtCalorie.Text, out calorieValue);
            if (!isNumeric || calorieValue < 0 || calorieValue > 5000)
            {
                MessageBox.Show("Calorie must be a numeric value between 0 and 5000.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (cmbUnit.SelectedItem == null)
            //{
            //    MessageBox.Show("You must select a unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (cmbCategory.SelectedItem == null)
            //{
            //    MessageBox.Show("You must select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            MessageBox.Show("Delete succeeded. Saving data...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBox();
            ClearComboBoxSelections();

            Food food = (Food)listBoxFoods.SelectedItem;
            foodService.Delete(food.FoodID);
            listBoxFoods.Items.Remove(food);
            ClearTextBox();
            ClearComboBoxSelections();
        }
        string _savePath;
        private void buttonUploadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Resmi yerel sistemde kaydet
                string filePath = openFileDialog.FileName;
                string savePath = Path.Combine(Application.StartupPath, "SavedImages", Path.GetFileName(filePath));

                // Klasör yoksa oluştur
                Directory.CreateDirectory(Path.GetDirectoryName(savePath));

                // Dosyayı kopyala veya taşı
                File.Copy(filePath, savePath, true);


                // savePath yolu, resmin uygulama içinde nerede saklandığını gösterir ve ihtiyacınız olduğunda kullanılabilir.
                _savePath = savePath;
            }
            else
            {
                MessageBox.Show("You have not selected any image. Please select an image to proceed.", "No Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
