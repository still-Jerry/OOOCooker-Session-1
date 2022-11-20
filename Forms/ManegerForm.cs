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
    using SQLClass = Modules.SQLClass;
    using BusinessClass = Modules.BusinessClass;
    using ViewsClass = Modules.ViewsClass;
    public partial class ManegerForm : Form
    {
        List<string> IdsForDelete = new List<string>();

        public ManegerForm()
        {
            InitializeComponent();
            SQLClass.SelectUsersForOrders(UsersСomboBox);
            UsersСomboBox.Items.Add("Не указано");
            SQLClass.SelectAddress(AddressComboBox);
            SQLClass.SelectStateOrders(StateComboBox);
            SQLClass.SelectOrderssInTable(dataGridView1);

        }

        private void ViewFormButton_Click(object sender, EventArgs e)
        {
            ViewProductForm Form = new ViewProductForm();
            this.Visible = false;
            Form.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                EditButton.Enabled = false;
                AddButton.Enabled = false;
                dataGridView1.MultiSelect = true;
                IdsForDelete.Clear();

            }
            else
            {
                dataGridView1.MultiSelect = false;
                EditButton.Enabled = true;
                AddButton.Enabled = true;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (!(dataGridView1.SelectedRows.Count >= 2 && dataGridView1.MultiSelect))
                {
                    IdsForDelete.Clear();
                }
                IdsForDelete.Add(Convert.ToString(dataGridView1.SelectedCells[0].Value));
                StateComboBox.Text = Convert.ToString(dataGridView1.SelectedCells[1].Value);
                DeliveryDateTimePicker.Value = Convert.ToDateTime(dataGridView1.SelectedCells[2].Value);
                OrderDateTimePicker.Value = Convert.ToDateTime(dataGridView1.SelectedCells[3].Value);

                ProductDataGridView.Rows.Clear();
                string[] products = Convert.ToString(dataGridView1.SelectedCells[4].Value).Replace(" ","").Split(',');
                for (int i = 0; i < products.Length; i+=2)
                {
                    ProductDataGridView.Rows.Add(products[i], products[i+1]);
                    //DataGridViewRow row = new DataGridViewRow();
                    //row.CreateCells(ProductDataGridView);  // this line was missing
                    //row.Cells[0].Value =products[i];
                    //row.Cells[1].Value = products[i+1];
                    //ProductDataGridView.Rows.Add(row);
                    
                }
                CodeLabel.Text = Convert.ToString(dataGridView1.SelectedCells[5].Value);
                AddressComboBox.Text = Convert.ToString(dataGridView1.SelectedCells[6].Value);
                UsersСomboBox.Text = Convert.ToString(dataGridView1.SelectedCells[7].Value);
            }
            catch { 
            
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SQLClass.DeleteSelectedOrders(IdsForDelete, dataGridView1);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string products = "";

                for (int i = 0; i < ProductDataGridView.Rows.Count - 1; i++)
                {
                    string art = ProductDataGridView.Rows[i].Cells[0].Value.ToString();
                    if (SQLClass.CheackArticleInProducts(art))
                    {
                        if (SQLClass.CheckCountInStock(art) < Convert.ToInt32(ProductDataGridView.Rows[i].Cells[1].Value))
                        {
                            MessageBox.Show("Количество заказаного товара " + art + " превышет наличие его на складе.", "Информация");
                            products = "";

                            return;
                        }
                        else
                        {
                            products += ProductDataGridView.Rows[i].Cells[0].Value;
                            products += ", ";
                            products += ProductDataGridView.Rows[i].Cells[1].Value;
                            if (i + 2 != ProductDataGridView.Rows.Count)
                            {
                                products += ", ";
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Артикул " + ProductDataGridView.Rows[i].Cells[0].Value.ToString() + " отсуствует.", "Ошибка");
                        products = "";
                        return;
                    }

                }
                if (products != "")
                {
                    Int32 kode = ViewsClass.GetKode();
                    while (SQLClass.CheackUniqKode(kode))
                    {
                        kode = ViewsClass.GetKode();
                    }

                    string del = DeliveryDateTimePicker.Value.Year + "." + DeliveryDateTimePicker.Value.Month + "." + DeliveryDateTimePicker.Value.Day;
                    string or = OrderDateTimePicker.Value.Year + "." + OrderDateTimePicker.Value.Month + "." + OrderDateTimePicker.Value.Day;
                    string us = UsersСomboBox.Text;
                    if (us == "Не указано")
                    {
                        us = "";
                    }
                    SQLClass.AddNewOrder(del, us, or, products, kode, AddressComboBox.Text, dataGridView1);
                }
                return;
            }
            catch { 
            
            }
        }

        private void OrderDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DeliveryDateTimePicker.Value= OrderDateTimePicker.Value.AddDays(3);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string products = "";

                for (int i = 0; i < ProductDataGridView.Rows.Count - 1; i++)
                {
                    string art = ProductDataGridView.Rows[i].Cells[0].Value.ToString();
                    if (SQLClass.CheackArticleInProducts(art))
                    {
                        if (SQLClass.CheckCountInStock(art) < Convert.ToInt32(ProductDataGridView.Rows[i].Cells[1].Value))
                        {
                            MessageBox.Show("Количество заказаного товара " + art + " превышет наличие его на складе.", "Информация");
                            products = "";

                            return;
                        }
                        else
                        {
                            products += ProductDataGridView.Rows[i].Cells[0].Value;
                            products += ", ";
                            products += ProductDataGridView.Rows[i].Cells[1].Value;
                            if (i + 2 != ProductDataGridView.Rows.Count)
                            {
                                products += ", ";
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Артикул " + ProductDataGridView.Rows[i].Cells[0].Value.ToString() + " отсуствует.", "Ошибка");
                        products = "";
                        return;
                    }

                }
                if (products != "")
                {
                  

                    string del = DeliveryDateTimePicker.Value.Year + "." + DeliveryDateTimePicker.Value.Month + "." + DeliveryDateTimePicker.Value.Day;
                    string or = OrderDateTimePicker.Value.Year + "." + OrderDateTimePicker.Value.Month + "." + OrderDateTimePicker.Value.Day;
                    string us = UsersСomboBox.Text;
                    if (us == "Не указано")
                    {
                        us = "";
                    }
                    SQLClass.UpdeateSelectedOrder(StateComboBox.Text, del, AddressComboBox.Text, 
                        UsersСomboBox.Text,or , products, CodeLabel.Text,IdsForDelete[0],dataGridView1);
                }
                return;
            }
            catch
            {

            }
        }

        
    }
}
