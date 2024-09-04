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
    public partial class DeviceUsesForm : Form
    {
        public DeviceUsesForm()
        {
            InitializeComponent();
        }

        private void DeviceUsesForm_Load(object sender, EventArgs e)
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
 
             سی تی اسکن طیف وسیعی از کاربردها در مراقبت های بهداشتی دارد که در ادامه به مهمترین کاربردهای آن اشاره می کنیم


             1-4-1-	تشخیص
              برای تشخیص موارد مختلف پزشکی و شرایط مختلفی مانند تومورها، عفونتها، شکستگیها و خونریزی داخلی استفاده میشود

             1-4-2-	برنامه ریزی درمان
             با ارائه اطلاعات دقیق در مورد منطقه مورد نظر به برنامه ریزی روشهای جراحی و درمانهای رادیوتراپی کمک میکند.

             1-4-3-	پایش پیشرفت بیماری
            سی تی اسکن پزشکان را قادر میسازد تا تغییرات تومورها یا سایر ناهنجاریها را در طول زمان نظارت کنند.
            
            1-4-4-	مداخلات هدایت کننده
             میتواند بیوپسی ها، درناژها و سایر روشهای کم تهاجمی را با دقت هدایت کند

";

        }
    }
}
