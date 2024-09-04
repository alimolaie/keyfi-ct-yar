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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // بررسی کنید که آیا فرم قبلاً باز نشده است
            if (Application.OpenForms["FormPersonalInfo"] == null)
            {
                // ایجاد و نمایش فرم جدید اگر هنوز باز نشده است
                FormPersonalInfo personalInfoForm = new FormPersonalInfo();
                personalInfoForm.Show();
            }
            else
            {
                // اگر فرم قبلاً باز شده، آن را فعال کنید
                Application.OpenForms["FormPersonalInfo"].BringToFront();
            }
        }
    }
}
