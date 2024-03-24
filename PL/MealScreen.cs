using BLL;
using Models.Concrete;
using Models.Enums;
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
    public partial class MealScreen : Form
    {
        public MealScreen(User user)
        {
            InitializeComponent();
            categoryService = new();
            foodService = new();
            _user = user;
        }

        CategoryService categoryService;
        FoodService foodService;
        User _user;

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonBreakfast_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MealScreen_Load(object sender, EventArgs e)
        {
            foreach (Category cat in categoryService.GetAll())
            {
                comboBoxCategory.Items.Add(cat);
            }


        }

        private void radioButtonLunch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStripCaregories_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    }
}
