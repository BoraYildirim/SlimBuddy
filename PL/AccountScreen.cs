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
                MessageBox.Show("Age field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ageValue;
            bool isNumeric = int.TryParse(txtNewAge.Text, out ageValue);
            if (!isNumeric || ageValue < 6 || ageValue > 99)
            {
                MessageBox.Show("Age must be a numeric value between 6 and 99.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNewHeight.Text))
            {
                MessageBox.Show("Height field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int heightValue;
            bool isNumeric2 = int.TryParse(txtNewHeight.Text, out heightValue);
            if (!isNumeric || heightValue < 30 || heightValue > 250)
            {
                MessageBox.Show("Height must be a numeric value between 30 and 250.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNewWeight.Text))
            {
                MessageBox.Show("Weight field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            int weightValue;
            bool isNumeric3 = int.TryParse(txtNewWeight.Text, out weightValue);
            if (!isNumeric || weightValue < 30 || weightValue > 250)
            {
                MessageBox.Show("Weight must be a numeric value between 30 and 250.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            UserDetail userDetail = userDetailService.GetById(_user.UserID);

            userDetail.Age = int.Parse(txtNewAge.Text);
            userDetail.Height = double.Parse(txtNewHeight.Text);
            userDetail.Weight = double.Parse(txtNewWeight.Text);
           // AgeControl(txtNewAge.Text, userDetail);
           // HeightControl(txtNewHeight.Text, userDetail);
           // WeightControl(txtNewWeight.Text, userDetail);


            userDetailService.Update(userDetail);

            lblHeight.Text = userDetailService.GetUserHeight(_user.UserID).ToString();
            lblWeight.Text = userDetailService.GetUserWeight(_user.UserID).ToString();
            lblAge.Text = userDetailService.GetUserAge(_user.UserID).ToString();

            txtNewAge.Text=string.Empty;
            txtNewHeight.Text=string.Empty;
            txtNewWeight.Text=string.Empty;

            MessageBox.Show("Successfully Update");
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

       
      

        private void txtNewAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
