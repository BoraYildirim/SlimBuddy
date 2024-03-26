using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using Models.Concrete;

namespace PL
{
    public partial class AccountScreen : Form
    {
        public AccountScreen(User user)
        {
            InitializeComponent();
            _user = user;
            userService = new();
            userDetailService = new();
        }

        User _user;
        UserService userService;
        UserDetailService userDetailService;

        private void AccountScreen_Load(object sender, EventArgs e)
        {
            lblEmail.Text = _user.Email;
            lblFirstName.Text = userDetailService.GetUserName(_user.UserID);
            lblLastName.Text = userDetailService.GetUserSurname(_user.UserID);
            lblGender.Text = userDetailService.GetUserGender(_user.UserID);
            lblHeight.Text = userDetailService.GetUserHeight(_user.UserID).ToString();
            lblWeight.Text = userDetailService.GetUserWeight(_user.UserID).ToString();
            lblAge.Text = userDetailService.GetUserAge(_user.UserID).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewAge.Text))
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNewHeight.Text))
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNewWeight.Text))
            {
                MessageBox.Show("Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            UserDetail userDetail = userDetailService.GetById(_user.UserID);

            AgeControl(txtNewAge.Text, userDetail);
            HeightControl(txtNewHeight.Text, userDetail);
            WeightControl(txtNewWeight.Text, userDetail);

            userDetailService.Update(userDetail);

            lblHeight.Text = userDetailService.GetUserHeight(_user.UserID).ToString();
            lblWeight.Text = userDetailService.GetUserWeight(_user.UserID).ToString();
            lblAge.Text = userDetailService.GetUserAge(_user.UserID).ToString();
        }

        public void AgeControl(string age, UserDetail userDetail)
        {
            int letterControl = 0;
            int digitControl = 0;
            int symbolConrol = 0;

            foreach (char c in age)
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
            if (letterControl == 0 && digitControl > 0 && symbolConrol == 0)
            {
                userDetail.Age = int.Parse(age);
            }
            else
            {
                MessageBox.Show("Values must have only Number");
            }

        }

        public void HeightControl(string height, UserDetail userDetail)
        {
            int letterControl = 0;
            int digitControl = 0;
            int symbolConrol = 0;

            foreach (char c in height)
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
            if (letterControl == 0 && digitControl > 0 && symbolConrol == 0)
            {
                userDetail.Height = double.Parse(height);
            }
            else
            {
                MessageBox.Show("Values must have only Number");
            }
        }
        public void WeightControl(string weight, UserDetail userDetail)
        {
            int letterControl = 0;
            int digitControl = 0;
            int symbolConrol = 0;

            foreach (char c in weight)
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
            if (letterControl == 0 && digitControl > 0 && symbolConrol == 0)
            {
                userDetail.Weight = int.Parse(weight);
            }
            else
            {
                MessageBox.Show("Values must have only Number");
            }
        }

        private void txtNewAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
