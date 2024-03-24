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

            if (textBoxEmail.Text != null && (textBoxEmail.Text.EndsWith("@gmail.com") || textBoxEmail.Text.EndsWith("@hotmail.com") || textBoxEmail.Text.EndsWith("@bilgeadamboost.com") || textBoxEmail.Text.EndsWith("@outlook.com") || textBoxEmail.Text.EndsWith("@yahoo.com")))
            {
                 if (userService.RegisterControl(textBoxEmail.Text))
                {
                    MessageBox.Show("This mail address is already taken");
                    return;
                    
                }
                else
                {
                    user.Email = textBoxEmail.Text;
                }



            }
            else
            {
                MessageBox.Show("Wrong Email address...");
                textBoxEmail.Text = string.Empty;
                return;
                
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
                MessageBox.Show("Name must have minimum 1-symbol,1-digit and 1-Punction");
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
                MessageBox.Show("LastName must have minimum 1-symbol,1-digit and 1-Punction");
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


            try
            {

                User user = new User();

                user.UserType = UserType.Regular;
                user.Status = Status.Active;
                EmailControl(textBoxEmail.Text, user);
                PasswordControl(textBoxPassword.Text, user);
                ConfirmPassword(textBoxPassword.Text, textBoxComfirmPassword.Text);

                UserDetail userDetail = new UserDetail();
                //userDetail.User = user;

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

                FormClear();
            }

            catch (Exception)
            {

                throw;
            }


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateaAccountScreen_Load(object sender, EventArgs e)
        {

            comboBoxGender.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
