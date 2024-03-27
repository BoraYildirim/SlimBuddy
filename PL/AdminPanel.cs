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
using Models.Enums;

namespace PL
{
    public partial class AdminPanel : Form
    {
        public AdminPanel(User user, Form form)
        {
            InitializeComponent();
            _form = form;
            _user = user;
            userService = new();
        }

        User _user;
        Form _form;
        UserService userService;

        private void AdminPanel_Load(object sender, EventArgs e)  //sayfa yüklendiğinde tüm kullanıcıları listboxta listeler
        {
            listBoxUserList.Items.Clear();
            foreach (User user in userService.GetAll())
            {
                if(user.UserType!= UserType.Admin)
                    listBoxUserList.Items.Add(user);
            }
        }

        private void buttonActive_Click(object sender, EventArgs e)  //seçilen kullanıcının durumunu aktife alır
        {
            User user = listBoxUserList.SelectedItem as User;

            if (user != null)
            {
                foreach (User use in userService.GetAll())
                {
                    if (use.UserType != UserType.Admin)
                    {
                        if (use.UserID == user.UserID)
                        {
                            user.Status = Status.Active;
                            userService.Update(user);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Choose Any User!");
            }
            listBoxUserList.Items.Clear();

            foreach (User us in userService.GetAll())
            {
                if (us.UserType != UserType.Admin)
                    listBoxUserList.Items.Add(us);
            }
        }

        private void buttonPassive_Click(object sender, EventArgs e)  //seçilen kullanıcının durumunu pasife alır
        {
            User user = listBoxUserList.SelectedItem as User;
            if (user != null)
            {
                foreach (User use in userService.GetAll())
                {
                    if (use.UserType != UserType.Admin)
                    {
                        if (use.UserID == user.UserID)
                        {
                            user.Status = Status.Passive;
                            userService.Update(user);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Choose Any User!");
            }

            listBoxUserList.Items.Clear();

            foreach (User us in userService.GetAll())
            {
                if (us.UserType != UserType.Admin)
                    listBoxUserList.Items.Add(us);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)  //sayfayı kapama butonu
        {
            this.Close();
            AdminLoginScreen adminLoginScreen = new AdminLoginScreen();
            adminLoginScreen.Show();
        }
    }
}
