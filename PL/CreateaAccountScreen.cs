using BLL;
using DAL.Repositories.Concrete;
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
                MessageBox.Show("Hatalı Kullanıcı Adı girdiniz...");
                textBoxEmail.Text = string.Empty;
            }
        }

     


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User user = new User();

            EmailControl(textBoxEmail.Text,user);
            
           
        }


    }
}
