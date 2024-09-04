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
    public partial class MonthlyTest5Form : Form
    {
        

        private void SetupDataGridView()
        {  dataGridView1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            }
       
        public MonthlyTest5Form()
        {
            InitializeComponent();
        }

        private void MonthlyTest5Form_Load(object sender, EventArgs e)
        {
            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView
            dataGridView1.RowCount = 6;

            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView1.AllowUserToAddRows = false;

            // بررسی اینکه آیا جدول حداقل چهار ردیف دارد، در غیر این صورت ردیف‌ها اضافه می‌شوند
            while (dataGridView1.Rows.Count < 6)
            {
                dataGridView1.Rows.Add();
            }

            // افزودن مقادیر به ستون سوم ردیف‌ها
            dataGridView1.Rows[0].Cells[2].Value = "بالا";
            dataGridView1.Rows[1].Cells[2].Value = "پایین";
            dataGridView1.Rows[2].Cells[2].Value = "چپ";
            dataGridView1.Rows[3].Cells[2].Value = "راست";
            dataGridView1.Rows[4].Cells[2].Value = "مرکز";

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
