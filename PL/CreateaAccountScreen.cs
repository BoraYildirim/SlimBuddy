using BLL;
using Microsoft.EntityFrameworkCore.Query.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Status = Models.Enums.Status;

namespace PL
{
    public partial class CreateaAccountScreen : Form
    {
        public CreateaAccountScreen()
        {
            InitializeComponent();
            userService = new();
            userDetailService = new();
        }
        UserService userService;
        UserDetailService userDetailService;


        public void EmailControl(string email, User user)
        {

            string pattern = @"^[\w-\.]+@([\w-]+\.)+com$";
            if (Regex.IsMatch(textBoxEmail.Text, pattern))
            {               
                user.Email = textBoxEmail.Text;
            }

        }

        public void PasswordControl(string password, User user)
        {
            int letterControl = 0;
            int digitControl = 0;
            int symbolConrol = 0;

            foreach (char c in password)
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
                user.Password = password;
            }
            else
            {
                MessageBox.Show("Password must have minimum 1-symbol,1-digit and 1-Punction");
            }


        }

        public void NameControl(string name, UserDetail userDetail)
        {
            int letterControl = 0;
            int digitControl = 0;
            int symbolConrol = 0;

            foreach (char c in name)
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
            if (letterControl > 0 && digitControl == 0 && symbolConrol == 0)
            {
                userDetail.Name = name;
            }
            else
            {
                MessageBox.Show("Name must have only letter");
            }
        }
        public void LastNameControl(string name, UserDetail userDetail)
        {
            int letterControl = 0;
            int digitControl = 0;
            int symbolConrol = 0;

            foreach (char c in name)
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
            if (letterControl > 0 && digitControl == 0 && symbolConrol == 0)
            {
                userDetail.Surname = name;
            }
            else
            {
                MessageBox.Show("LastName must have only letter");
            }
        }

        public void ConfirmPassword(string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                MessageBox.Show("Password do not match. Please Check...");
            }
        }
        public void GenderSelected(string gender, UserDetail userDetail)
        {
            if (gender == "Female")
            {
                userDetail.Gender = Gender.Female;
            }
            else if (gender == "Male")
            {
                userDetail.Gender = Gender.Male;
            }
            else
            {
                MessageBox.Show("Please Choose Gender!");
            }
        }

        public void HeightControl(double height)
        {
            if (height <= 55 || height >= 250)
            {
                MessageBox.Show("Hatakı Boy");
                throw new Exception();
            }
        }
        public void WeightControl(double height)
        {
            if (height <= 55 || height >= 250)
            {
                MessageBox.Show("Hatalı Kilo");
                throw new Exception();
            }
        }


        public void FormClear()
        {
            textBoxEmail.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxComfirmPassword.Text = string.Empty;
            comboBoxGender.SelectedIndex = 0;
            textBoxAge.Text = string.Empty;
            textBoxWeight.Text = string.Empty;
            textBoxHeight.Text = string.Empty;
        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {

            int kontrol = 0;

            foreach (User us in userService.GetAll())
            {
                if (us.Email == textBoxEmail.Text)
                {

                    kontrol = 1;
                    break;
                }


            }

            if (kontrol == 1)
            {

                MessageBox.Show("Upss Somethings gone wrong");
            }
            else
            {
                try
                {
                    HeightControl(double.Parse(textBoxHeight.Text));
                    WeightControl(double.Parse(textBoxWeight.Text));



                    User user = new User();


                    user.UserType = UserType.Regular;
                    user.Status = Status.Active;
                    EmailControl(textBoxEmail.Text, user);
                    PasswordControl(textBoxPassword.Text, user);
                    ConfirmPassword(textBoxPassword.Text, textBoxComfirmPassword.Text);

                    UserDetail userDetail = new UserDetail();


                    GenderSelected(comboBoxGender.Text, userDetail);
                    NameControl(textBoxName.Text, userDetail);
                    LastNameControl(textBoxLastName.Text, userDetail);
                    userDetail.Height = double.Parse(textBoxHeight.Text);
                    userDetail.Weight = double.Parse(textBoxWeight.Text);
                    userDetail.Age = int.Parse(textBoxAge.Text);
                    userDetail.ActivityLevel = ActivityLevel.MidLevel;


                    user.UserDetail = userDetail;
                    userService.Add(user);
                    MessageBox.Show("Succesfully");
                }
                catch (Exception)
                {

                    MessageBox.Show("Try again");
                }

            }


            FormClear();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateaAccountScreen_Load(object sender, EventArgs e)
        {

            comboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxComfirmPassword.UseSystemPasswordChar = true;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
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

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // E-posta formatını kontrol etmek için düzenli ifade
            string pattern = @"^[\w-\.]+@([\w-]+\.)+com$";
            if (Regex.IsMatch(textBoxEmail.Text, pattern))
            {
                // Metin kutusunun arka plan rengini yeşil yaparak, formatın doğru olduğunu göster
                textBoxEmail.BackColor = Color.LightGreen;
            }
            else
            {
                // Metin kutusunun arka plan rengini kırmızı yaparak, formatın yanlış olduğunu göster
                textBoxEmail.BackColor = Color.Salmon;
            }
        }
    }
}
