using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ООО__Поваренок_.Modules
{
    class BusinessClass
    {
        public static void ChangeDiscoutColor(Label l1, Label l2)
        {
            if (Convert.ToInt32(l1.Text.Replace("%", "")) >= 15)
            {
                l1.BackColor = Color.Chartreuse;
            }
            else
            {
                l1.BackColor = Color.White;

            }
            if (Convert.ToInt32(l2.Text.Replace("%", "")) >= 15)
            {
                l2.BackColor = Color.Chartreuse;
            }
            else
            {
                l2.BackColor = Color.White;

            }
        }

        public static void ChangeCountPagesAndNotes(Label Pages, Label Notes, int count, int pageN) {
            string AllPages;
            if (count % 2 == 0)
            {
                AllPages = count/2+"";
            }
            else {
                AllPages = (count / 2) + 1 + "";
            }
            Pages.Text = "стр. " + pageN + " из " +AllPages;
            Notes.Text = "зап. " + (pageN * 2).ToString() + "\nиз " + count;

        }
        public static void ChangeLableName(Label FIOLabel, List <string> UserInfoList)
        {

            if (UserInfoList.Count != 0)
            {
                FIOLabel.Text = UserInfoList[1] + " " + UserInfoList[2] + " " + UserInfoList[3];

            }
            else
            {
                FIOLabel.Text = "";
            }

        }

        public static void WriteReport() { 
        
        }

    }
}
