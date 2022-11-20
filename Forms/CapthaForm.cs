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
    public partial class CapthaForm : Form
    {
        public static string capthatext = "";
        public CapthaForm()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            capthatext = ViewsClass.Captha(label1, label2, label3, label4, label5);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == capthatext)
            {
                AuthorizationForm.EnabledAuthorizationForm = true;

                this.Visible = false;
                AuthorizationForm.EnabledAuthorizationForm = true;
            }
            else {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                textBox1.Text = "";
                capthatext = ViewsClass.Captha(label1, label2, label3, label4, label5);
                
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            textBox1.Text = "";

            capthatext = ViewsClass.Captha(label1, label2, label3, label4, label5);

        }

    
    }
}
