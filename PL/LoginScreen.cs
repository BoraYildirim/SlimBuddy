using BLL;
using Models.Concrete;
using Models.Enums;

namespace PL
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            userService = new();
        }

        UserService userService;


        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateaAccountScreen createForm = new CreateaAccountScreen();
            this.Hide();
            createForm.ShowDialog();
            this.Show();

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginScreen formAdminLoginScreen = new AdminLoginScreen();
            this.Hide();
            formAdminLoginScreen.ShowDialog();
            this.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            int control = 0;

            foreach (User us in userService.GetAll())
            {
                if (us.Email == textBoxEmail.Text && us.Password == textBoxPassword.Text && us.UserType == UserType.Regular && us.Status != Status.Passive)
                {
                    HomeScreen formHomeScreen = new HomeScreen(us, this);
                    formHomeScreen.Show();
                    control = 1;
                    this.Hide();

                }

            }
            if (control == 0)
            {
                MessageBox.Show("Incorrect User Login!");
                textBoxEmail.Clear();
                textBoxPassword.Clear();
            }



        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;

            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
