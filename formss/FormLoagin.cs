using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formss
{
    public partial class FormLoagin : Form
    {
        public FormLoagin()
        {
            InitializeComponent();
        }

        private void btnLoagin_Click(object sender, EventArgs e)
        {

            // بررسی کنید که آیا فرم قبلاً باز نشده است
            if (Application.OpenForms["Form1"] == null)
            {
                // ایجاد و نمایش فرم جدید اگر هنوز باز نشده است
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                // اگر فرم قبلاً باز شده، آن را فعال کنید
                Application.OpenForms["Form1"].BringToFront();
            }
        }
    }
}
