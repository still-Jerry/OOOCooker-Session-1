using System;
using System.IO;
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
    using SQLClass = Modules.SQLClass;
    using BusinessClass = Modules.BusinessClass;
    using ViewsClass = Modules.ViewsClass;

    public partial class ViewProductForm : Form
    {
        public static Boolean EnabledViewForm = false;
        public static FilterForm Form = new FilterForm();
        public static Int32 PoroductsCount = 0;
        public static Int32 page = 1;
        public static Int32 Note = 0;

        public static String FilterCost = "";
        public static String FilterDiscount = "";

        public static List<String> ProductArticleNumber = new List<string>();
        public static List<String> ProductName = new List<string>();
        public static List<String> ProductDescription = new List<string>();
        public static List<String> ProductPhoto = new List<string>();
        public static List<Decimal> ProductCost = new List<Decimal>();
        public static List<Int32> ProductDiscountAmount = new List<Int32>();
        public static List<String> ProductManufacturer = new List<string>();

        public ViewProductForm()
        {
            InitializeComponent();
            
            ProductGroupBox2.ContextMenuStrip = contextMenuStrip2;
            ProductGroupBox2.ContextMenuStrip.Cursor = Cursors.Hand;

            ProductGroupBox1.ContextMenuStrip = contextMenuStrip1;
            ProductGroupBox1.ContextMenuStrip.Cursor = Cursors.Hand;
          

            FilterDiscount = "";
            FilterCost = "";
            ViewProduct();
            if (SQLClass.OrderIsEmpty())
            {
                OrderButton.Visible = true;
            }
            else {
                OrderButton.Visible = false;
            }
            BusinessClass.ChangeLableName(FIOLabel, AuthorizationForm.UserInfo);

            try
            {
                if (AuthorizationForm.UserInfo[6] == "2")
                {
                    MenegerButton.Visible = true;
                }
                else if (AuthorizationForm.UserInfo[6] == "3")
                {
                    MenegerButton.Visible = true;
                    AdminButton.Visible = true;
                }
            }
            catch { }
        }

        private void ViewProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AuthorizationFormButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm.UserInfo.Clear();
            AuthorizationForm Form = new AuthorizationForm();
            this.Visible = false;
            Form.ShowDialog();

        }

        private void добавитьвToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderButton.Visible = true;
            string а = ProductArticleNumber[Note];
            if (SQLClass.CountThisProductInOrder(а)>0)
            {
                SQLClass.UpdateProductInOrder(а);
            }else{
                SQLClass.AddProductInOrder(а);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            EnabledViewForm = false;
            this.Enabled = EnabledViewForm;
            Form.ShowDialog();
            this.Enabled = EnabledViewForm;
            ViewProduct();

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if ((page < PoroductsCount / 2 && PoroductsCount % 2 == 0) || (page < ((PoroductsCount / 2)+1) && PoroductsCount % 2 != 0))
            {
                page++;
                Note += 2;
                UpdateProduct();
                BusinessClass.ChangeCountPagesAndNotes(PagesLabel, NoteLabel, PoroductsCount, page);

                BusinessClass.ChangeDiscoutColor(DiscountLabel1, DiscountLabel2);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;

                Note -= 2;
                UpdateProduct();
                BusinessClass.ChangeCountPagesAndNotes(PagesLabel, NoteLabel, PoroductsCount, page);

                BusinessClass.ChangeDiscoutColor(DiscountLabel1, DiscountLabel2);
            }
        }

        private void NoteLabel_TextChanged(object sender, EventArgs e)
        {
            if (page == 1) {
                //BackButton.Enabled = false;
            }

            else if ((page == PoroductsCount / 2) && (PoroductsCount % 2 == 0) ||(page == (PoroductsCount / 2) +1) && (PoroductsCount % 2 != 0))
            {
                //NextButton.Enabled = false;

            }
            else {
                BackButton.Enabled = true;
                NextButton.Enabled = true;
            
            }
        }


        private void UpdateProduct()
        {
            ProductGroupBox1.Visible = true;

            try
            {
                var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
                var path = Path.Combine(exePath, "UsersComponents\\PoductsImage\\" + ProductPhoto[Note]);
                //Лёлик, надо выучить!;


                NameLabel1.Text = ProductName[Note];
                DiscriptinListBox1.Items[0] = ProductDescription[Note];
                DiscountLabel1.Text = ProductDiscountAmount[Note] + "%";
                if (ProductDiscountAmount[Note] > 0)
                {
                    OldlCostLabel1.Visible = true;
                    DiscountLabel1.Visible = true;

                    OldlCostLabel1.Text = ProductCost[Note].ToString();
                }
                else
                {
                    OldlCostLabel1.Visible = false;
                    DiscountLabel1.Visible = false;

                }

                ImagePictureBox1.ImageLocation = Path.Combine(exePath, "UsersComponents\\PoductsImage\\" + ProductPhoto[Note]);

                CostLabel1.Text = (ProductCost[Note] - (ProductDiscountAmount[Note] * ProductCost[Note] / 100)).ToString();
                ManufactureLabel1.Text = ProductManufacturer[Note];

            }
            catch (Exception ex)
            {
                ProductGroupBox1.Visible = false;

            }
            ProductGroupBox2.Visible = true;

            try
            {
                var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
               
                //2++++++++++++++++++++
                NameLabel2.Text = ProductName[Note + 1];
                DiscriptinListBox2.Items[0] = ProductDescription[Note + 1];
                DiscountLabel2.Text = ProductDiscountAmount[Note + 1] + "%";
                if (ProductDiscountAmount[Note + 1] > 0)
                {
                    OldlCostLabel2.Visible = true;
                    DiscountLabel2.Visible = true;

                    OldlCostLabel2.Text = ProductCost[Note + 1].ToString();
                }
                else
                {
                    OldlCostLabel2.Visible = false;
                    DiscountLabel2.Visible = false;

                }
                CostLabel2.Text = (ProductCost[Note + 1] - (ProductDiscountAmount[Note + 1] * ProductCost[Note + 1] / 100)).ToString();
                ManufactureLabel2.Text = ProductManufacturer[Note + 1];
                ImagePictureBox2.ImageLocation = Path.Combine(exePath, "UsersComponents\\PoductsImage\\" + ProductPhoto[Note + 1]);
            }
            catch {
                ProductGroupBox2.Visible = false;
            }
            }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ViewProduct();
        }
        private void ViewProduct()
        {

            PoroductsCount = 0;
            page = 1;
            Note = 0;

            SQLClass.SelectProduct(ProductArticleNumber, ProductName,
               ProductDescription, ProductPhoto, ProductCost,
               ProductDiscountAmount, ProductManufacturer,
               SearchTextBox.Text, FilterCost,FilterDiscount);

            PoroductsCount = ProductArticleNumber.Count;

            UpdateProduct();


            BusinessClass.ChangeCountPagesAndNotes(PagesLabel, NoteLabel, PoroductsCount, page);

            BusinessClass.ChangeDiscoutColor(DiscountLabel1, DiscountLabel2);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            OrderForm Form = new OrderForm();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderButton.Visible = true;
            string а = ProductArticleNumber[Note+1];
            if (SQLClass.CountThisProductInOrder(а)>0)
            {
                SQLClass.UpdateProductInOrder(а);
            }
            else
            {
                SQLClass.AddProductInOrder(а);
            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm Form = new AdminForm();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void MenegerButton_Click(object sender, EventArgs e)
        {
            ManegerForm Form = new ManegerForm();
            this.Visible = false;
            Form.ShowDialog();
        }

    }
}
