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
    public partial class AnnualTest8Form : Form
    {
            
        public AnnualTest8Form()
        {
            InitializeComponent();
        }

        private void AnnualTest8Form_Load(object sender, EventArgs e)
        {

            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView
            dataGridView1.RowCount = 9;

            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView1.AllowUserToAddRows = false;


            // بررسی اینکه حداقل هشت ردیف وجود دارد
            if (dataGridView1.Rows.Count >= 8)
            {
                // افزودن مقدار 0 به ردیف اول ستون دوم
                dataGridView1.Rows[0].Cells[2].Value = 0;

                // افزودن مقدار 1 به ردیف دوم ستون دوم
                dataGridView1.Rows[1].Cells[2].Value = 1;

                // افزودن مقدار 2 به ردیف سوم ستون دوم
                dataGridView1.Rows[2].Cells[2].Value = 2;

                // افزودن مقدار 3 به ردیف چهارم ستون دوم
                dataGridView1.Rows[3].Cells[2].Value = 3;

                // افزودن مقدار 4 به ردیف پنچم ستون دوم
                dataGridView1.Rows[4].Cells[2].Value = 4;

                // افزودن مقدار 5 به ردیف ششم ستون دوم
                dataGridView1.Rows[5].Cells[2].Value = 5;

                // افزودن مقدار 6 به ردیف هفتم ستون دوم
                dataGridView1.Rows[6].Cells[2].Value = 6;

                // افزودن مقدار 7 به ردیف هشتم ستون دوم
                dataGridView1.Rows[7].Cells[2].Value = 7;

            }
            else
            {
                MessageBox.Show("لطفا حداقل هشت ردیف در DataGridView اضافه کنید.");
            }
           
        }
    }
}
