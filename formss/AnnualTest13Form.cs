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
    public partial class AnnualTest13Form : Form
    {

        private void SetupDataGridView()
        {
        }


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }
        public AnnualTest13Form()
        {
            InitializeComponent();
        }

        private void AnnualTest13Form_Load(object sender, EventArgs e)
        {
            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView
            dataGridView1.RowCount = 3;

            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView1.AllowUserToAddRows = false;

            // بررسی اینکه آیا جدول حداقل چهار ردیف دارد، در غیر این صورت ردیف‌ها اضافه می‌شوند
            while (dataGridView1.Rows.Count < 3)
            {
                dataGridView1.Rows.Add();
            }

            // افزودن مقادیر به ستون سوم ردیف‌ها
            dataGridView1.Rows[0].Cells[3].Value = "Maximum super gantry tilt";
            dataGridView1.Rows[1].Cells[3].Value = "Maximum inferior gantry tilt ";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}