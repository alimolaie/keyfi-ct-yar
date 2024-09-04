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
    public partial class DeviceBasicsForm : Form
    {
        public DeviceBasicsForm()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeviceBasicsForm_Load(object sender, EventArgs e)
        {

            // تنظیم متن به راست به چپ
            richTextBox1.RightToLeft = RightToLeft.Yes;
         

            // قفل کردن RichTextBox برای جلوگیری از ویرایش
            richTextBox1.ReadOnly = true;

            // تنظیم فونت برای نمایش صحیح متن فارسی
            Font font = new Font("Vazir", 9);
            richTextBox1.Font = font;

            // تنظیم حاشیه داخلی برای فاصله دادن متن از لبه‌ها
            richTextBox1.Padding = new Padding(10);

            // قرار دادن متن مورد نظر
            richTextBox1.Text = @"

              دستگاه های توموگرافی کامپیوتری (CT) از پرتوهای اشعه ایکس برای تولید تصاویر دقیق و مقطعی از بدن استفاده میکنند.  
             این دستگاه از یک لوله اشعه ایکس تشکیل شده است که پرتوی از اشعه ایکس و یک آرایه آشکارساز برای جذب تشعشعات ارسالی ساطع میکند. 
             همانطور که بیمار از طریق اسکنر حرکت میکند، لوله اشعه ایکس و آشکارسازها در اطراف آنها میچرخند 
            و اندازه گیری های متعددی از تضعیف اشعه ایکس انجام میدهند. سپس این اندازه‌گیری‌ها توسط الگوریتم‌های کامپیوتری پردازش می‌شوند 
             تا تصاویری ایجاد کنند که ساختارهای داخلی را نشان می‌دهند.


";

        }
    }
}
