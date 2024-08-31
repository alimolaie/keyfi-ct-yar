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
    public partial class AnnualTest11Form : Form
    {
        public AnnualTest11Form()
        {
            InitializeComponent();
        }

        private void AnnualTest11Form_Load(object sender, EventArgs e)
        {
            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView
            dataGridView1.RowCount = 5;
            dataGridView2.RowCount = 5;
            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView1.AllowUserToAddRows = true;
            dataGridView2.AllowUserToAddRows = true;

        }
    }
}
