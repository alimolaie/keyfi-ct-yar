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
    public partial class Information2 : Form
    {
        public Information2()
        {
            InitializeComponent();
        }

        private void information2_Load(object sender, EventArgs e)
        {
            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView
            dataGridView1.RowCount = 5;

            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView1.AllowUserToAddRows = true;
        }
    }
}
