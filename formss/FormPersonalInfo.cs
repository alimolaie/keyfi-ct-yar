using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace formss
{
    public partial class FormPersonalInfo : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public FormPersonalInfo()
        {
            InitializeComponent();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=.;Initial Catalog=ct;Integrated Security=True;Trust Server Certificate=True");
            cn.Open();
        }

        private void btnSaveInformation_Click(object sender, EventArgs e)
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
