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
    public partial class DailyTest1Form : Form
    {

        private void SetupDataGridView()
        {
            
        }

       
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            }
        
        public DailyTest1Form()
        {
            InitializeComponent();
        }

        private void DailyTest1Form_Load(object sender, EventArgs e)
        {

            // تنظیم تعداد ردیف‌های پیش‌فرض DataGridView
            dataGridView1.RowCount =5;

            // تنظیم اجازه برای اضافه کردن ردیف توسط کاربر
            dataGridView1.AllowUserToAddRows = false;

            // بررسی اینکه آیا جدول حداقل چهار ردیف دارد، در غیر این صورت ردیف‌ها اضافه می‌شوند
            while (dataGridView1.Rows.Count < 4)
            {
                dataGridView1.Rows.Add();
            }

            // افزودن مقادیر به ستون سوم ردیف‌ها
            dataGridView1.Rows[0].Cells[3].Value = "آب";
            dataGridView1.Rows[1].Cells[3].Value = "تفلون";
            dataGridView1.Rows[2].Cells[3].Value = "آکرلیک";
            dataGridView1.Rows[3].Cells[3].Value = "هوا";
           
            // افزودن مقادیر به ستون دوم ردیف‌ها
            dataGridView1.Rows[0].Cells[2].Value = 0;
            dataGridView1.Rows[1].Cells[2].Value = 990;
            dataGridView1.Rows[2].Cells[2].Value = 120;
            dataGridView1.Rows[3].Cells[2].Value = -1000;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
            

        }
    }
