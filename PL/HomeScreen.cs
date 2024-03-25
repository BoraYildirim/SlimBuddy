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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PL
{
    public partial class HomeScreen : Form
    {
        public HomeScreen(User user, Form form)
        {
            InitializeComponent();
            _user = user;
            _form = form;

        }

        User _user;
        Form _form;

        private void aDDMEALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MealScreen mealScreen = new MealScreen(_user);
            mealScreen.MdiParent = this;
            mealScreen.Dock = DockStyle.Fill;
            this.Width = mealScreen.Width;
            this.Height = mealScreen.Height + 60;
            mealScreen.Show();

        }

        private void mEALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MealScreen mealScreen = new MealScreen(_user);
            mealScreen.MdiParent = this;
            mealScreen.Dock = DockStyle.Fill;
            this.Width = mealScreen.Width;
            this.Height = mealScreen.Height + 60;
            mealScreen.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fOODToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aCCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountScreen accountScreen = new AccountScreen(_user);
            accountScreen.MdiParent = this;
            accountScreen.Dock = DockStyle.Fill;
            this.Width = accountScreen.Width;
            this.Height = accountScreen.Height + 60;
            accountScreen.Show();
        }
    }
}
