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
    public partial class AnnualTest5Form : Form
    {
       
        public AnnualTest5Form()
        {
            InitializeComponent();
        }

        private void AnnualTest5Form_Load(object sender, EventArgs e)
        {
            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView
            dataGridView1.RowCount = 2;

            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView1.AllowUserToAddRows = true;
            // مقداردهی به سلول‌های DataGridView
            dataGridView1.Rows[0].Cells[10].Value = "سر";
            dataGridView1.Rows[1].Cells[11].Value = "شکم";
            dataGridView1.Rows[0].Cells[11].Value = "سر";
            dataGridView1.Rows[1].Cells[10].Value = "تنه";

            // جلوگیری از تغییر سلول‌ها توسط کاربر
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true; // ستون‌ها را فقط خواندنی می‌کنیم
            }

        
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
