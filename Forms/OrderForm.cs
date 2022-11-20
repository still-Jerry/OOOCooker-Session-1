using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using  Word = Microsoft.Office.Interop.Word;
namespace ООО__Поваренок_.Forms
{
    using SQLClass = Modules.SQLClass;
    using BusinessClass = Modules.BusinessClass;
    using ViewsClass = Modules.ViewsClass;

    public partial class OrderForm : Form
    {
        public static Int32 OrdersCount = 0;
        public static Int32 page = 1;
        public static Int32 Note = 0;

        public static List<String> OrderArticleNumber = new List<string>();
        public static List<String> OrderName = new List<string>();
        public static List<String> OrderDescription = new List<string>();
        public static List<String> OrderPhoto = new List<string>();
        public static List<Decimal> OrderCost = new List<Decimal>();
        public static List<Int32> OrderDiscountAmount = new List<Int32>();
        public static List<String> OrderManufacturer = new List<string>();
        public static List<Int32> countpro = new List<Int32>();

        public OrderForm()
        {
            InitializeComponent();
            ViewOrders();
            OrderGroupBox1.ContextMenuStrip = contextMenuStrip1;
            OrderGroupBox1.ContextMenuStrip.Cursor = Cursors.Hand;
            OrderGroupBox2.ContextMenuStrip = contextMenuStrip2;
            OrderGroupBox2.ContextMenuStrip.Cursor = Cursors.Hand;

            SQLClass.SelectAddress(AddressComboBox);
            BusinessClass.ChangeLableName(FIOLabel, AuthorizationForm.UserInfo);
        }

        private void ViewProductFormButton_Click(object sender, EventArgs e)
        {
            ViewProductForm Form = new ViewProductForm();
            this.Visible = false;
            Form.ShowDialog();

        }
        private void ViewOrders()
        {
            SQLClass.SelectOrders(OrderArticleNumber, OrderName,
               OrderDescription, OrderPhoto, OrderCost,
               OrderDiscountAmount, OrderManufacturer, countpro);

            OrdersCount = OrderArticleNumber.Count;

            UpdateOrder();


            BusinessClass.ChangeCountPagesAndNotes(PagesLabel, NoteLabel, OrdersCount, page);

            BusinessClass.ChangeDiscoutColor(DiscountLabel1, DiscountLabel2);
        }
        private void UpdateOrder()
        {
            OrderGroupBox1.Visible = true;

            try
            {
                var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file
                var path = Path.Combine(exePath, "UsersComponents\\PoductsImage\\" + OrderPhoto[Note]);
                //Лёлик, надо выучить!;

                numericUpDown1.Value = countpro[Note];
                NameLabel1.Text = OrderName[Note];
                DiscriptinListBox1.Items[0] = OrderDescription[Note];
                DiscountLabel1.Text = OrderDiscountAmount[Note] + "%";
                if (OrderDiscountAmount[Note] > 0)
                {
                    OldlCostLabel1.Visible = true;
                    DiscountLabel1.Visible = true;

                    OldlCostLabel1.Text = OrderCost[Note].ToString();
                }
                else
                {
                    OldlCostLabel1.Visible = false;
                    DiscountLabel1.Visible = false;

                }

                ImagePictureBox1.ImageLocation = Path.Combine(exePath, "UsersComponents\\PoductsImage\\" + OrderPhoto[Note]);

                CostLabel1.Text = (OrderCost[Note] - (OrderDiscountAmount[Note] * OrderCost[Note] / 100)).ToString();
                ManufactureLabel1.Text = OrderManufacturer[Note];

            }
            catch (Exception ex)
            {
                OrderGroupBox1.Visible = false;

            }
            OrderGroupBox2.Visible = true;

            try
            {
                var exePath = AppDomain.CurrentDomain.BaseDirectory;//path to exe file

                //2++++++++++++++++++++
                numericUpDown2.Value = countpro[Note+1];
                NameLabel2.Text = OrderName[Note + 1];
                DiscriptinListBox2.Items[0] = OrderDescription[Note + 1];
                DiscountLabel2.Text = OrderDiscountAmount[Note + 1] + "%";
                if (OrderDiscountAmount[Note + 1] > 0)
                {
                    OldlCostLabel2.Visible = true;
                    DiscountLabel2.Visible = true;

                    OldlCostLabel2.Text = OrderCost[Note + 1].ToString();
                }
                else
                {
                    OldlCostLabel2.Visible = false;
                    DiscountLabel2.Visible = false;

                }
                CostLabel2.Text = (OrderCost[Note + 1] - (OrderDiscountAmount[Note + 1] * OrderCost[Note + 1] / 100)).ToString();
                ManufactureLabel2.Text = OrderManufacturer[Note + 1];
                ImagePictureBox2.ImageLocation = Path.Combine(exePath, "UsersComponents\\PoductsImage\\" + OrderPhoto[Note + 1]);
            }
            catch
            {
                OrderGroupBox2.Visible = false;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if ((page < OrdersCount / 2 && OrdersCount % 2 == 0) || (page < ((OrdersCount / 2) + 1) && OrdersCount % 2 != 0))
            {
                page++;
                Note += 2;
                UpdateOrder();
                BusinessClass.ChangeCountPagesAndNotes(PagesLabel, NoteLabel, OrdersCount, page);

                BusinessClass.ChangeDiscoutColor(DiscountLabel1, DiscountLabel2);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;

                Note -= 2;
                UpdateOrder();
                BusinessClass.ChangeCountPagesAndNotes(PagesLabel, NoteLabel, OrdersCount, page);

                BusinessClass.ChangeDiscoutColor(DiscountLabel1, DiscountLabel2);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Enabled)
            {
                numericUpDown1.Value = SQLClass.ChangeCountInOrder(OrderArticleNumber[Note], Convert.ToInt32(numericUpDown1.Value));
                if (numericUpDown1.Value == 0) {
                    ViewOrders();
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Enabled)
            {
                numericUpDown2.Value = SQLClass.ChangeCountInOrder(OrderArticleNumber[Note + 1], Convert.ToInt32(numericUpDown2.Value));
                if (numericUpDown2.Value == 0)
                {
                    ViewOrders();
                }               
            }
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void изменитьКоличествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Уверены что хотите изменить количество?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                numericUpDown1.Enabled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Уверены что хотите изменить количество?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                numericUpDown2.Enabled = true;
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = Directory.GetCurrentDirectory() + "\\UsersComponents\\Tickets\\Шаблон.docx";

                //var FileName = AppDomain.CurrentDomain.BaseDirectory + "UsersComponents\\Tickets\\Шаблон.docx";//path to exe file

                Random rtm = new Random();
                string talon = rtm.Next(0, 999999).ToString();

                string atricle = "";
                string name = "";
                string count = "";
                string cost = "";
                string discount = "";
                string newcost = "";
                double itogo = 0;
                double itogowithout = 0;
                
                string fordb = "";
                for (int i = 0; i < OrderArticleNumber.Count; i++) {
                    fordb += OrderArticleNumber[i] + ", " + countpro[i];
                   if ((i + 2) != OrderArticleNumber.Count)
                    {
                        fordb += ", ";
                    }
                    atricle += OrderArticleNumber[i] + "\n";
                    name += OrderName[i] + "\n";
                    count += countpro[i] + "\n";
                    cost += OrderCost[i] + "\n";
                    discount += OrderDiscountAmount[i] + "\n";
                    newcost += ((OrderCost[i] - (OrderDiscountAmount[i] * OrderCost[i] / 100)) * countpro[i]) +"\n";
                    itogo += Convert.ToDouble((OrderCost[i] - (OrderDiscountAmount[i] * OrderCost[i] / 100)) * countpro[i]);
                    itogowithout += Convert.ToInt32(OrderCost[i] * countpro[i]);
                }
                Int32 kode = ViewsClass.GetKode();
                while (SQLClass.CheackUniqKode(kode))
                {
                    kode = ViewsClass.GetKode();
                }
                string del = DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day+3;
                string or = DateTime.Now.Year + "." + DateTime.Now.Month + "." + DateTime.Now.Day;
                string user = "";
                if (AuthorizationForm.UserInfo.Count > 0) { 
                user+=AuthorizationForm.UserInfo[1]+" "+AuthorizationForm.UserInfo[2]+" "+
                    AuthorizationForm.UserInfo[3];
                }
                string id = SQLClass.AddNewOrderTicket(del, user, or, fordb, kode, AddressComboBox.Text);

                Word.Application wdApp = new Word.Application();
                //Word.Document wdDoc = null;
                Object wdMiss = System.Reflection.Missing.Value;


                var wordDocument = wdApp.Documents.Open(FileName);

                ReplaceWordStub("{Order}", id, wordDocument);
                ReplaceWordStub("{Date}",DateTime.Now.ToString(), wordDocument);
                ReplaceWordStub("{talon}", talon, wordDocument);
                ReplaceWordStub("{article}", atricle, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{count}", count, wordDocument);
                ReplaceWordStub("{cost}", cost, wordDocument);
                ReplaceWordStub("{dicount}", discount, wordDocument);
                ReplaceWordStub("{newcost}", newcost, wordDocument);
                ReplaceWordStub("{itog}", Convert.ToString(itogo), wordDocument);
                ReplaceWordStub("{itogdis}", (itogowithout - itogo).ToString(), wordDocument);
                ReplaceWordStub("{code}", kode.ToString(), wordDocument);
                ReplaceWordStub("{address}", AddressComboBox.Text, wordDocument);
                ReplaceWordStub("{Fio}", user, wordDocument);

                
               

                wdApp.Visible = true;
                
                object filename = FileName.Replace("Шаблон.docx", talon) + "_.doc";
                //сохраняем документ на диске
                wordDocument.SaveAs(ref filename);

                // Закрываем текущий документ
                wordDocument.Close(ref wdMiss, ref wdMiss, ref wdMiss);
                wordDocument = null;

                // Закрываем приложение Word
                wdApp.Quit(ref wdMiss, ref wdMiss, ref wdMiss);
                ReportButton.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            try
            {
                var range = wordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
            }
            catch { }
        }
  

 
    }
}
