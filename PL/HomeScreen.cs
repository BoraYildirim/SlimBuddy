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
            FoodScreen foodScreen = new FoodScreen(_user);
            foodScreen.MdiParent = this;
            foodScreen.Dock = DockStyle.Fill;
            foodScreen.Show();
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

        private void sUMMARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryScreen summaryScreen = new SummaryScreen(_user);
            summaryScreen.MdiParent = this;
            summaryScreen.Dock = DockStyle.Fill;
            summaryScreen.Show();
        }

        private void dAILYCALORIEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyCalorieScreen dailyCalorieScreen = new DailyCalorieScreen(_user);
            dailyCalorieScreen.MdiParent = this;
            dailyCalorieScreen.Dock = DockStyle.Fill;
            this.Width = dailyCalorieScreen.Width;
            this.Height = dailyCalorieScreen.Height + 60;
            dailyCalorieScreen.Show();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void aNALYSISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalysisScreen analysisScreen = new AnalysisScreen(_user);
            analysisScreen.MdiParent = this;
            analysisScreen.Dock = DockStyle.Fill;
            this.Width = analysisScreen.Width;
            this.Height = analysisScreen.Height + 60;
            analysisScreen.Show();
        }
    }
}
