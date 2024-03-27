using BLL;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Status = Models.Enums.Status;
using User = Models.Concrete.User;

namespace PL
{
    public partial class CreateaAccountScreen : Form
    {
        public CreateaAccountScreen() 
        {
            InitializeComponent();
            // UserService ve UserDetailService sınıflarının newlenmesi.
            userService = new();
            userDetailService = new();
        }

        // UserService ve UserDetailService sınıflarının referanslarını tutacak değişkenler.
        UserService userService;
        UserDetailService userDetailService;
        
        /// <summary>
        /// Formun içeriğini temizleme işlevi.
        /// </summary>
        public void FormClear()  
        { 
            textBoxEmail.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxComfirmPassword.Text = string.Empty;
            comboBoxGender.SelectedItem = null;
            textBoxAge.Text = string.Empty;
            textBoxWeight.Text = string.Empty;
            textBoxHeight.Text = string.Empty;
            checkBoxShowPassword.Checked = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))   //boşluk kontrolü
            {
                MessageBox.Show("Email field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxEmail.BackColor == Color.Salmon)         //arkaplan rengi kırımızı ise hata verir
            {
                MessageBox.Show("Please Enter the Correct Format email address. (.....@....com) or the email address already exists ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text))    //boşluk kontrolü
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int spaceCount = textBoxName.Text.Count(c => c == ' ');     //karakter kontrolü
            bool isValidTurkishLettersAndSpaces = Regex.IsMatch(textBoxName.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces || spaceCount > 4)  //boşluk sayısı kontrolü
            {
                MessageBox.Show("Name field must contain only letters (including Turkish letters) and a maximum of 4 spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxLastName.Text))    //boşluk kontrolü
            {
                MessageBox.Show("Last Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int spaceCount2 = textBoxLastName.Text.Count(c => c == ' ');  //karakter kontrolü
            bool isValidTurkishLettersAndSpaces2 = Regex.IsMatch(textBoxLastName.Text, @"^[a-zA-ZığüşöçİĞÜŞÖÇ ]+$");

            if (!isValidTurkishLettersAndSpaces2 || spaceCount2 > 4)   //boşluk sayısı kontrolü
            {
                MessageBox.Show("Last Name field must contain only letters (including Turkish letters) and a maximum of 4 spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))    //boşluk kontrolü
            {
                MessageBox.Show("Password field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int letterControl = 0;
            int digitControl = 0;
            int symbolConrol = 0;

            foreach (char c in textBoxPassword.Text) //parola kontrolü
            {
                if (char.IsLetter(c))
                {
                    letterControl++;
                }
                if (char.IsDigit(c))
                {
                    digitControl++;
                }
                if (char.IsSymbol(c) || char.IsSeparator(c) || char.IsPunctuation(c))
                {
                    symbolConrol++;
                }
            }
            if (letterControl > 0 && digitControl > 0 && symbolConrol > 0)
            {

            }
            else
            {
                MessageBox.Show("Password must have minimum 1-symbol,1-digit and 1-Punction");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxComfirmPassword.Text)) //boşluk kontrolü
            {
                MessageBox.Show("Comfirm Password field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPassword.Text != textBoxComfirmPassword.Text)  //confirm password ile password eşitliğine bakılır
            {
                MessageBox.Show("Password do not match. Please Check...");
                return;
            }

            if (comboBoxGender.SelectedItem == null)        //cinsiyet kontrolü
            {
                MessageBox.Show("You must select a Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAge.Text))     //boşluk kontrolü
            {
                MessageBox.Show("Age field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ageValue;
            bool isNumeric = int.TryParse(textBoxAge.Text, out ageValue);
            if (!isNumeric || ageValue < 6 || ageValue > 99)    //yaş kontrolü
            {
                MessageBox.Show("Age must be a numeric value between 6 and 99.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxHeight.Text))  //boşluk kontrolü
            {
                MessageBox.Show("Height field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int heightValue;
            bool isNumeric2 = int.TryParse(textBoxHeight.Text, out heightValue);
            if (!isNumeric || heightValue < 30 || heightValue > 250)    //boy kontrolü
            {
                MessageBox.Show("Height must be a numeric value between 30 and 250.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxWeight.Text))          //boşluk kontrolü
            {
                MessageBox.Show("Weight field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int weightValue;
            bool isNumeric3 = int.TryParse(textBoxWeight.Text, out weightValue);
            if (!isNumeric || weightValue < 30 || weightValue > 250)    //kilo kontrolü
            {
                MessageBox.Show("Weight must be a numeric value between 30 and 250.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            User user = new User();       //user oluşturulup değerleri verildi          

            user.UserType = UserType.Regular;
            user.Status = Status.Active;
            user.Email = textBoxEmail.Text;
            user.Password = textBoxPassword.Text;

            UserDetail userDetail = new UserDetail();       //userdetail oluşturuluğ değerleri verildi
            userDetail.Gender = (Gender)comboBoxGender.SelectedIndex+1;
            userDetail.Name = textBoxName.Text;
            userDetail.Surname = textBoxLastName.Text;
            userDetail.Age = int.Parse(textBoxAge.Text);
            userDetail.Height = double.Parse(textBoxHeight.Text);
            userDetail.Weight = double.Parse(textBoxWeight.Text);
            userDetail.ActivityLevel = ActivityLevel.MidLevel;
            user.UserDetail = userDetail;       //oluşturulan userın detailına userdetail atandı
            userService.Add(user);              //user eklendi
            MessageBox.Show("Create Account...Succesfully");
            FormClear();
        }


        private void textBoxEmail_TextChanged_1(object sender, EventArgs e)
        {
            // E-posta formatını kontrol etmek için düzenli ifade
            string pattern = @"^[\w-\.]+@([\w-]+\.)+com$";
            if (Regex.IsMatch(textBoxEmail.Text, pattern) && !userService.CheckEntries(textBoxEmail.Text))
            {
                textBoxEmail.BackColor = Color.LightGreen;
            }
            else
            {
                // Metin kutusunun arka plan rengini kırmızı yaparak, formatın yanlış olduğunu göster
                textBoxEmail.BackColor = Color.Salmon;
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateaAccountScreen_Load_1(object sender, EventArgs e)
        {
            // Cinsiyet seçimini içeren comboBox'a seçenekler ekleniyor.
            string Male = "Male";
            string Female = "Female";
          
            comboBoxGender.Items.Add(Male);
            comboBoxGender.Items.Add(Female);

            // Parola girişi alanları için karakterlerin gizli olması sağlanıyor.
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxComfirmPassword.UseSystemPasswordChar = true;
        }

        private void checkBoxShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            // "checkBoxShowPassword" işaretlendiğinde veya işaret kaldırıldığında gerçekleşen olay.
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxComfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxComfirmPassword.UseSystemPasswordChar = true;
            }
        }

        // Fare sürükleme işlemi için gerekli değişkenler.
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            // Fare panel üzerine tıklandığında gerçekleşen olay.
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            // Fare panel üzerinde sürüklendiğinde gerçekleşen olay.
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp_1(object sender, MouseEventArgs e)
        {
            // Fare panel üzerinden kaldırıldığında gerçekleşen olay.
            dragging = false;
        }
    }
}
