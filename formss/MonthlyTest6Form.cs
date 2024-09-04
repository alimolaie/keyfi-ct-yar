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
    public partial class MonthlyTest6Form : Form
    {
        public MonthlyTest6Form()
        {
            InitializeComponent();
        }

        private void MonthlyTest6Form_Load(object sender, EventArgs e)
        {
            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView1
            dataGridView1.RowCount = 5;

            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView1.AllowUserToAddRows = true;

            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView2
            dataGridView2.RowCount = 5;

            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView2.AllowUserToAddRows = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
