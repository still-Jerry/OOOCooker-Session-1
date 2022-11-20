using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООО__Поваренок_.Forms
{
    public partial class FilterForm : Form
    {
     
        public FilterForm()
        {
            InitializeComponent();
            CostСomboBox.SelectedIndex=2;
            DiscountComboBox.SelectedIndex = 3;
        }

        private void FilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ViewProductForm.EnabledViewForm = true;
        }

        private void DropButton_Click(object sender, EventArgs e)
        {
            CostСomboBox.SelectedIndex = 2;
            DiscountComboBox.SelectedIndex = 3;
            ViewProductForm.FilterCost = "";
            ViewProductForm.FilterDiscount = "";
        }

        private void CostСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CostСomboBox.SelectedIndex){
                case(0):
                    ViewProductForm.FilterCost = "ASC";
                    break;
                case(1):
                    ViewProductForm.FilterCost = "Desc";
                    break;
                default:
                    break;
            }
            
        }

        private void DiscountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DiscountComboBox.SelectedIndex)
            {
                case (0):
                    ViewProductForm.FilterDiscount = "<10";
                    break;
                case (1):
                    ViewProductForm.FilterDiscount = "10-15";
                    break;
                case (2):
                    ViewProductForm.FilterDiscount = ">=15";
                    break;
                default:
                    break;
            }
        }

     
    }
}
