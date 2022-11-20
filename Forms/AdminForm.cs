using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООО__Поваренок_.Forms
{
    using SQLClass = Modules.SQLClass;
    using BusinessClass = Modules.BusinessClass;
    using ViewsClass = Modules.ViewsClass;
    public partial class AdminForm : Form
    {

        List<string> ArticlsForDelete = new List<string>();
        public AdminForm()
        {
            InitializeComponent();
            SQLClass.SelectProductsInTable(dataGridView1);
            SQLClass.SelectCategory(CategoryComboBox);

            var exePath = AppDomain.CurrentDomain.BaseDirectory;
            string[] photos = Directory.GetFiles(exePath + "UsersComponents\\PoductsImage\\");
            for (int i = 0; i < photos.Length; i++)
            {
                string photoname = photos[i].Replace(exePath + "UsersComponents\\PoductsImage\\","");
                PhotoСomboBox.Items.Add(photoname);
            }
            PhotoСomboBox.Items.Add("Не указано");
            PhotoСomboBox.Text = "Не указано";
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (!(dataGridView1.SelectedRows.Count>=2 && dataGridView1.MultiSelect))
                {
                    ArticlsForDelete.Clear();
                }
                ArticlsForDelete.Add(Convert.ToString(dataGridView1.SelectedCells[0].Value));

                NameTextBox.Text = Convert.ToString(dataGridView1.SelectedCells[1].Value);
                DiscriprionTextBox.Text = Convert.ToString(dataGridView1.SelectedCells[2].Value);
                ManufactureTrextBox.Text = Convert.ToString(dataGridView1.SelectedCells[3].Value);
                ProviderTextBox.Text = Convert.ToString(dataGridView1.SelectedCells[4].Value);
                CountNumericUpDown.Value = Convert.ToInt32(dataGridView1.SelectedCells[5].Value);
                CategoryComboBox.Text = Convert.ToString(dataGridView1.SelectedCells[6].Value);
                StockNumericUpDown.Value = Convert.ToInt32(dataGridView1.SelectedCells[7].Value);
                UnitiTextBox.Text = Convert.ToString(dataGridView1.SelectedCells[8].Value);
                DiscountNumericUpDown.Value = Convert.ToInt32(dataGridView1.SelectedCells[9].Value);
                MaxDiscountNumericUpDown.Value = Convert.ToInt32(dataGridView1.SelectedCells[10].Value);

                if (Convert.ToString(dataGridView1.SelectedCells[11].Value) == "")
                {
                    PhotoСomboBox.Text = "Не указано";
                }
                else
                {
                    PhotoСomboBox.Text = Convert.ToString(dataGridView1.SelectedCells[11].Value);

                }
                var exePath = AppDomain.CurrentDomain.BaseDirectory;
                pictureBox2.ImageLocation = Path.Combine(exePath, "UsersComponents\\PoductsImage\\" + PhotoСomboBox.Text);
                
            }
            catch
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                EditButton.Enabled = false;
                AddButton.Enabled = false;
                dataGridView1.MultiSelect = true;
                ArticlsForDelete.Clear();

            }
            else {
                dataGridView1.MultiSelect = false;
                EditButton.Enabled = true;
                AddButton.Enabled = true;
            }
        }

        private void ViewFormButton_Click(object sender, EventArgs e)
        {
            ViewProductForm Form = new ViewProductForm();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SQLClass.DeleteSelectedProducts(ArticlsForDelete, dataGridView1);
           

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ViewsClass.TextBoxIsEmpty(NameTextBox) && ViewsClass.TextBoxIsEmpty(ManufactureTrextBox) && ViewsClass.TextBoxIsEmpty(ProviderTextBox) && ViewsClass.TextBoxIsEmpty(UnitiTextBox))
            {
                string photo = PhotoСomboBox.Text;
                if (photo == "Не указано")
                {
                    photo = "picture.png";
                }
                SQLClass.UpdeateSelectedProduct(ArticlsForDelete[0], NameTextBox.Text, DiscriprionTextBox.Text,
                    ManufactureTrextBox.Text, ProviderTextBox.Text, CountNumericUpDown.Value.ToString(),
                    CategoryComboBox.Text, StockNumericUpDown.Value.ToString(),UnitiTextBox.Text,
                    DiscountNumericUpDown.Value.ToString(), MaxDiscountNumericUpDown.Value.ToString(),
                    photo, dataGridView1
                    );
            }
            else {
                MessageBox.Show("Данные не обновлены. Проверьте заполненность всех полей", "Информация");
            }
        }

        private void PhotoСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var exePath = AppDomain.CurrentDomain.BaseDirectory;
                pictureBox2.ImageLocation = Path.Combine(exePath, "UsersComponents\\PoductsImage\\" + PhotoСomboBox.Text);
            }
            catch { }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

           
            if (ViewsClass.TextBoxIsEmpty(NameTextBox) && ViewsClass.TextBoxIsEmpty(ManufactureTrextBox) && ViewsClass.TextBoxIsEmpty(ProviderTextBox) && ViewsClass.TextBoxIsEmpty(UnitiTextBox))
            {
                string photo = PhotoСomboBox.Text;
                if (photo == "Не указано")
                {
                    photo = "";
                }
                string atricle = ViewsClass.GetArticle();
                while (SQLClass.CheackUniqArticle(atricle))
                {
                    atricle = ViewsClass.GetArticle();
                }
                SQLClass.AddNewProduct(atricle, NameTextBox.Text, DiscriprionTextBox.Text,
                    ManufactureTrextBox.Text, ProviderTextBox.Text, CountNumericUpDown.Value.ToString(),
                    CategoryComboBox.Text, StockNumericUpDown.Value.ToString(), UnitiTextBox.Text,
                    DiscountNumericUpDown.Value.ToString(), MaxDiscountNumericUpDown.Value.ToString(),
                    photo, dataGridView1
                    );
            }
            else
            {
                MessageBox.Show("Данные не добавлены. Проверьте заполненность всех полей", "Информация");
            }

        }

        private void UnitiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled=true;
            }
            
            
        }

   
    }
}
