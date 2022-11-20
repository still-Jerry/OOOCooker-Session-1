using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ООО__Поваренок_.Modules
{
    class ViewsClass
    {
        public static string Captha(Label l1,Label l2,Label l3,Label l4,Label l5){
            Random rnd = new Random();
            string ALF = "qwertyuiopasdfghjklzxcvbnm1234567890";
           l1.Text +=ALF[rnd.Next(ALF.Length)];
           l2.Text += ALF[rnd.Next(ALF.Length)];
           l3.Text += ALF[rnd.Next(ALF.Length)];
           l4.Text += ALF[rnd.Next(ALF.Length)];
           l5.Text += ALF[rnd.Next(ALF.Length)];
           return l1.Text + l2.Text + l3.Text + l4.Text+ l5.Text;
        }
        public static string GetArticle()
        {
            Random rnd = new Random();
            string ALF = "qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            string article="";
            for (int i = 0; i < 6; i++) {
                article += ALF[rnd.Next(ALF.Length)];
            }
            return article;
        }
        public static Int32 GetKode()
        {
            Random rnd = new Random();
            
            return rnd.Next(100,999);
        }
        public static Boolean TextBoxIsEmpty(TextBox Field)
        {
            if (Field.Text.Replace(" ", "") == "")
            {
                return false;
            }
            else {
                return true;
            }
        }


       
    }
}
