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
    public partial class WeeklyAndDailyTestingEquipmentForm : Form
    {
        public WeeklyAndDailyTestingEquipmentForm()
        {
            InitializeComponent();
        }

        private void WeeklyAndDailyTestingEquipmentForm_Load(object sender, EventArgs e)
        {
                // تنظیم متن به راست به چپ
    richTextBox1.RightToLeft = RightToLeft.Yes;
   

    // قفل کردن RichTextBox برای جلوگیری از ویرایش
    richTextBox1.ReadOnly = true;

    // تنظیم فونت برای نمایش صحیح متن فارسی
    richTextBox1.Font = new Font("Tahoma", 12);

    // قرار دادن متن مورد نظر
    richTextBox1.Text = @" 
آزمون نویز 

 تجهیزات و لوازم موردنیاز: 
فانتوم آب سی تی اسکن (و یا ظرف پلاستیکی) استوانه¬
 ای شکل که دارای حدوداً20cm قطر بوده و محتوی آب باشد. 


آزمون صحت عدد سیتی اسکن

تجهیزات و لوازم موردنیاز: 
فانتوم مخصوص این آزمون که حاوی چند ناحیه متفاوت متشکل از مواد مختلف از قبیل آب، آکریلیک، هوا، تفلون و مانند این ها است. 
  ";
        }
    }
}
