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
    public partial class WeeklyTest1Form : Form
    {// لیستی از نام‌های سر ردیف‌ها
        private List<string> rowHeadersText = new List<string> { " 1", " 2", " 3" };

        private void SetupDataGridView()
        {
            // پاک کردن ستون‌های پیشین
            dataGridView1.Columns.Clear();

            // افزودن 4 ستون به DataGridView
            dataGridView1.Columns.Add("Column1", "ضخامت های مختلف تصویر گیری در سطح فانتوم");
            dataGridView1.Columns.Add("Column2", "پروتکل تصویرگیری");
            dataGridView1.Columns.Add("Column3", "میانگین عدد سی تی");
            dataGridView1.Columns.Add("Column4", "انحراف معیار عددی سی تی ");
          

            // تنظیم تعداد ردیف‌ها
            dataGridView1.Rows.Add(3);

            // فعال کردن نمایش سر ردیف‌ها
            dataGridView1.RowHeadersVisible = true;

            // تنظیم عرض سر ردیف‌ها
            dataGridView1.RowHeadersWidth = 20;

            // جلوگیری از تغییر نام سر ستون‌ها توسط کاربر
            dataGridView1.AllowUserToAddRows = true;   // جلوگیری از افزودن ردیف جدید توسط کاربر
            dataGridView1.AllowUserToDeleteRows = false; // جلوگیری از حذف ردیف توسط کاربر
            dataGridView1.AllowUserToResizeColumns = false; // جلوگیری از تغییر سایز ستون‌ها
            dataGridView1.AllowUserToResizeRows = false;  // جلوگیری از تغییر سایز ردیف‌ها

            // متصل کردن رویداد RowPostPaint به DataGridView
            dataGridView1.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
        }

        // رویداد برای تنظیم نام سر ردیف‌ها
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;

            // بررسی اینکه تعداد ردیف‌ها کافی است
            if (e.RowIndex < rowHeadersText.Count)
            {
                string rowText = rowHeadersText[e.RowIndex];  // متن دلخواه برای سر ردیف

                // تنظیم فرمت برای مرکزیت متن
                var centerFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                // رسم متن دلخواه در داخل سر ردیف
                e.Graphics.DrawString(rowText, this.Font, SystemBrushes.ControlText, e.RowBounds.Left + 10, e.RowBounds.Top + 4, centerFormat);
            }
        }
        public WeeklyTest1Form()
        {
            InitializeComponent();
        }

        private void WeeklyTest1Form_Load(object sender, EventArgs e)
        {
            // فراخوانی تنظیمات DataGridView
            SetupDataGridView();
        }
    }
}
