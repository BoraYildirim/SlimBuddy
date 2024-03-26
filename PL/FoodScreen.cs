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


            cmbCategory.DataSource = categoryService.GetAll();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";

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

        public void EmptyErrorCheck()
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (foodService.CheckEntries(txtName.Text))
            {
                MessageBox.Show("the food name already exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (listBoxFoods.SelectedItem != null)
            {
                MessageBox.Show("deselect from the list to add product");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            if (foodService.CheckEntries(txtName.Text))
            {
                MessageBox.Show("the food name already exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Food food = new Food();
            food.Unit = (Unit)cmbUnit.SelectedIndex;
            food.CategoryID = cmbCategory.SelectedIndex;
            food.Name = txtName.Text;
            food.Calorie = double.Parse(txtCalorie.Text);
            food.Image = txtImage.Text;
           // food.Image = _savePath;
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


            MessageBox.Show("Validation succeeded. Saving data...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBoxFoods.Items.Add(food);
            ClearTextBox();
            ClearComboBoxSelections();

        }

        public void ClearTextBox()
        {
            txtName.Text = string.Empty;
            txtCalorie.Text = string.Empty;

        }

        private void ClearComboBoxSelections()
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
                Food food = (Food)listBoxFoods.SelectedItem;

                txtName.Text = food.Name;
                txtCalorie.Text = food.Calorie.ToString();
                txtImage.Text = food.Image;
                cmbUnit.SelectedItem = food.Unit.ToString();
                cmbCategory.SelectedItem = categoryService.GetById(food.CategoryID);
              //  pictureBox1.Image = Image.FromFile(food.Image);
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxFoods.SelectedItem == null)
            {
                MessageBox.Show("Please Choose Food !!!");
                return;
            }
            //  EmptyErrorCheck();
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


            Food food = (Food)listBoxFoods.SelectedItem;

            food.Unit = (Unit)cmbUnit.SelectedIndex;
            food.CategoryID = cmbCategory.SelectedIndex;
            food.Name = txtName.Text;
            food.Calorie = double.Parse(txtCalorie.Text);
            food.Image = txtImage.Text;
           // food.Image = _savePath;
            foodService.Update(food);

            int selectedIndex = listBoxFoods.SelectedIndex;
            listBoxFoods.Items.Remove(food);
            listBoxFoods.Items.Insert(selectedIndex, food);

            MessageBox.Show("Update succeeded. Saving data...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBox();
            ClearComboBoxSelections();


        }




        private void FoodScreen_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxFoods.ClearSelected();
        }

        private void buttonDeleted_Click(object sender, EventArgs e)
        {
            if (listBoxFoods.SelectedItem == null)
            {
                MessageBox.Show("Please Choose Food !!!");
                return;
            }
            //  EmptyErrorCheck();
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

            MessageBox.Show("Delete succeeded. Saving data...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearTextBox();
            ClearComboBoxSelections();

            Food food = (Food)listBoxFoods.SelectedItem;
            foodService.Delete(food.FoodID);
            listBoxFoods.Items.Remove(food);
            ClearTextBox();
            ClearComboBoxSelections();

        }
        //string _savePath;
        //private void buttonUploadImage_Click(object sender, EventArgs e)
        //{
            
            
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        // Resmi yerel sistemde kaydet
        //        string filePath = openFileDialog.FileName;
        //        string savePath = Path.Combine(Application.StartupPath, "SavedImages", Path.GetFileName(filePath));

        //        // Klasör yoksa oluştur
        //        Directory.CreateDirectory(Path.GetDirectoryName(savePath));

        //        // Dosyayı kopyala veya taşı
        //        File.Copy(filePath, savePath, true);
               

        //        // savePath yolu, resmin uygulama içinde nerede saklandığını gösterir ve ihtiyacınız olduğunda kullanılabilir.
        //        _savePath = savePath;
        //    }
        //    else
        //    {
        //        MessageBox.Show("You have not selected any image. Please select an image to proceed.", "No Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }



        //}
       
    }
}
