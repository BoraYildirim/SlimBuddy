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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PL
{
    public partial class CreateaAccountScreen : Form
    {
        public CreateaAccountScreen()
        {
            InitializeComponent();
            UserService userService = new UserService();
        }
        UserService userService;


        public void EmailControl(string email, User user)
        {

            if (textBoxEmail.Text != null && (textBoxEmail.Text.EndsWith("@gmail.com") || textBoxEmail.Text.EndsWith("@hotmail.com") || textBoxEmail.Text.EndsWith("@bilgeadamboost.com") || textBoxEmail.Text.EndsWith("@outlook.com") || textBoxEmail.Text.EndsWith("@yahoo.com")) && userService.RegisterControl(textBoxEmail.Text) == false)
            {
                user.Email = textBoxEmail.Text;

            }
            else
            {
                MessageBox.Show("Wrong Email address...");
                textBoxEmail.Text = string.Empty;
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
            if (letterControl > 0 && digitControl >0 && symbolConrol>0)
            {
                user.Password = password;
            }
            else
            {
                MessageBox.Show("Password must have minimum 1-symbol,1-digit and 1-Punction");
            }


        }

        public void NameControl(string name,UserDetail userDetail)
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
               userDetail.Name=name;
            }
            else
            {
                MessageBox.Show("Name must have minimum 1-symbol,1-digit and 1-Punction");
            }
        }



        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserDetail userDetail = new UserDetail();
            userDetail.User = user;

            EmailControl(textBoxEmail.Text, user);
            PasswordControl(textBoxPassword.Text,user);
            NameControl(textBoxName.Text, userDetail);
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
