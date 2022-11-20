using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ООО__Поваренок_.Forms
{
    using SQLClass = Modules.SQLClass;
    using BusinessClass = Modules.BusinessClass;
    using ViewsClass = Modules.ViewsClass;
    public partial class AuthorizationForm : Form
    {
        public static Boolean EnabledAuthorizationForm = false;
       
        int countEntarense = 1;
        public static List<String> UserInfo = new List<String>();
        public AuthorizationForm()
        {
            InitializeComponent();
        }

           private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

           private void EnteranceButton_Click(object sender, EventArgs e)
           {
               try
               {
                   UserInfo=SQLClass.SelectUser(LoginTextBox.Text, PwdTextBox.Text, UserInfo);
                 
                   if (UserInfo.Count!=0 && countEntarense!=0)
                   {
                       ViewProductForm ViewForm = new ViewProductForm();
                       this.Visible = false;
                       ViewForm.ShowDialog();
                   }else if (countEntarense==0){
                       CapthaForm CForm = new CapthaForm();
                       this.Enabled = EnabledAuthorizationForm;
                       CForm.ShowDialog();
                       if (EnabledAuthorizationForm) {
                           if (UserInfo.Count != 0)
                           {
                               ViewProductForm ViewForm = new ViewProductForm();
                               this.Visible = false;
                               ViewForm.ShowDialog();
                           }
                           else {
                               this.Enabled = false;
                               Thread.Sleep(1000);
                               this.Enabled = true;
                           }
                       }

                   }
                   else if (countEntarense > 0) {
                       countEntarense--;
                   }

                   if (UserInfo.Count == 0)
                   {
                       MessageBox.Show("Несоотвествие логина или пароля.", "Ошибка");

                   }
               }
               catch { }
           }

           private void ViewButton_Click(object sender, EventArgs e)
           {
                ViewProductForm ViewForm = new ViewProductForm();
                       this.Visible = false;
                       ViewForm.ShowDialog();
           }

         

      
    }
}
