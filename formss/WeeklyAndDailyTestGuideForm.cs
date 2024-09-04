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
    public partial class WeeklyAndDailyTestGuideForm : Form
    {
        public WeeklyAndDailyTestGuideForm()
        {
            InitializeComponent();
        }

        private void WeeklyAndDailyTestGuideForm_Load(object sender, EventArgs e)
        {
                // تنظیم متن به راست به چپ
    richTextBox1.RightToLeft = RightToLeft.Yes;
 

    // قفل کردن RichTextBox برای جلوگیری از ویرایش
    richTextBox1.ReadOnly = true;

    // تنظیم فونت برای نمایش صحیح متن فارسی
    richTextBox1.Font = new Font("Vazir", 9);

    // قرار دادن متن مورد نظر
    richTextBox1.Text = @"

         آزمون های هفتگی : 

         آزمون نویز:  
         هدف از انجام این آزمون، بررسی میزان انحراف معیار عدد سی تی اسکن (نویز) مربوط به نواحی مختلف تصویر تهیه شده توسط دستگاه سی تی اسکن است.


         آزمون های روزانه
: 
          آزمون صحت عدد سیتی اسکن: 
         هدف از انجام این آزمون بررسی صحت عدد سی تی اسکن به دست آمده مربوط به تصویر سی تی اسکن مواد مختلف با دانسیته الکترونی متفاوت است. 
 ";
        }
    }
}
