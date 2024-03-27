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
        private void AccountScreen_Load(object sender, EventArgs e)   //Kullanıcının bilgileri formda dolu gelmektedir.
        {          
            lblEmail.Text= _user.Email;
            lblFirstName.Text = userDetailService.GetUserName(_user.UserID);
            lblLastName.Text = userDetailService.GetUserSurname(_user.UserID);
            lblGender.Text = userDetailService.GetUserGender(_user.UserID);
            lblHeight.Text = userDetailService.GetUserHeight(_user.UserID).ToString();
            lblWeight.Text = userDetailService.GetUserWeight(_user.UserID).ToString();
            lblAge.Text = userDetailService.GetUserAge(_user.UserID).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)           
        {
            if (string.IsNullOrWhiteSpace(txtNewAge.Text))          //boşluk kontrolü
            {
                MessageBox.Show("Age field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ageValue;
            bool isNumeric = int.TryParse(txtNewAge.Text, out ageValue);
            if (!isNumeric || ageValue < 6 || ageValue > 99)        //yaş kontrolü ve numerik değer kontrolü
            {
                MessageBox.Show("Age must be a numeric value between 6 and 99.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNewHeight.Text))       //boşluk kontrolü
            {
                MessageBox.Show("Height field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int heightValue;
            bool isNumeric2 = int.TryParse(txtNewHeight.Text, out heightValue);
            if (!isNumeric || heightValue < 30 || heightValue > 250)    //boy kontrolü ve numerik kontrolü
            {
                MessageBox.Show("Height must be a numeric value between 30 and 250.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNewWeight.Text))           //boşluk kontrolü
            {
                MessageBox.Show("Weight field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            int weightValue;
            bool isNumeric3 = int.TryParse(txtNewWeight.Text, out weightValue);
            if (!isNumeric || weightValue < 30 || weightValue > 250)    //kilo kontorlğ ve numerik kontrolü
            {
                MessageBox.Show("Weight must be a numeric value between 30 and 250.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserDetail userDetail = userDetailService.GetById(_user.UserID);

            userDetail.Age = int.Parse(txtNewAge.Text);
            userDetail.Height = double.Parse(txtNewHeight.Text);
            userDetail.Weight = double.Parse(txtNewWeight.Text);

            userDetailService.Update(userDetail);

            lblHeight.Text = userDetailService.GetUserHeight(_user.UserID).ToString();
            lblWeight.Text = userDetailService.GetUserWeight(_user.UserID).ToString();
            lblAge.Text = userDetailService.GetUserAge(_user.UserID).ToString();

            txtNewAge.Text=string.Empty;
            txtNewHeight.Text=string.Empty;
            txtNewWeight.Text=string.Empty;

            MessageBox.Show("Successfully Update"); //kayıt başarılı
        }       
    }
}
