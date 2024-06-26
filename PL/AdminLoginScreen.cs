﻿using BLL;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class AdminLoginScreen : Form
    {
        public AdminLoginScreen()
        {
            InitializeComponent();
            userService = new();
        }

        UserService userService;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int control = 0;

            foreach (User us in userService.GetAll())   //admin bilgilerinin kontrolü ve login işlemi    
            {
                if (us.Email == textBoxEmail.Text && us.Password == textBoxPassword.Text && us.UserType == UserType.Admin)
                {
                    AdminPanel adminPanel = new AdminPanel(us, this);
                    adminPanel.ShowDialog();
                    control = 1;
                    this.Hide();                 
                }
            }
            if (control == 0)
            {
                MessageBox.Show("Incorrect Admin Login!");
                textBoxEmail.Clear();
                textBoxPassword.Clear();
            }       
        }

        private void buttonClose_Click(object sender, EventArgs e) //formu kapama butonu
        {
            this.Close();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)  //checkbox a basınca parolayı görülür hale getirme 
        {
            if (checkBoxShow.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void AdminLoginScreen_Load(object sender, EventArgs e) //sayfa yüklendiğinde parola tipi karakterler gizli halde 
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
