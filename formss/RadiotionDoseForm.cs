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
    public partial class RadiotionDoseForm : Form
    {
        public RadiotionDoseForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadiotionDoseForm_Load(object sender, EventArgs e)
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


             پرتوهای یونیزان در سی تی اسکن استفاده می شود و بیماران را در معرض مقادیر کمی از اشعه قرار می دهد. دوز تابش بر حسب 
             میلی سیورت (mSv) اندازه گیری می شود. دوز موثر معیاری است که حساسیت اندام های مختلف به تابش را در نظر می گیرد. دوز 
            تابش سی تی اسکن به عواملی مانند نوع اسکنر، پارامترهای اسکن و اندازه بیمار بستگی دارد
             در حالی که سی تی اسکن اطلاعات تشخیصی ضروری را ارائه میدهد، دوز تابش نسبتاً بالاتری را در مقایسه با سایر روش های 
             تصویربرداری مانند اشعه ایکس معمولی ارائه می دهد. عوامل موثر در دوز بالاتر در ادامه توضیح داده شده اند
             
            1-5-1-	مدت زمان اسکن
             سی تی اسکن اغلب شامل چرخش های متعدد لوله اشعه ایکس و آرایه آشکارساز است که منجر به زمان نوردهی طولانی تر می شود

             1-5-2-	رزولوشن فضایی
             سی تی اسکن برای تولید تصاویر دقیق به وضوح فضایی بالایی نیاز دارد، که نیاز به دوز تابشی بالاتری دارد.

             1-5-3-	حالت اسکن
             برخی از حالت های اسکن، مانند CT مارپیچی، مستلزم قرار گرفتن مداوم در معرض اشعه ایکس است که به بالا رفتن دوز کمک می کند.
 
             1-5-4-	میدان دید
             میدان دید اسکن بزرگتر برای پوشش ناحیه بزرگتر بدن می تواند منجر به دوز تابش بالاتر شود.
             تلاش‌های مستمر در فناوری CT برای به حداقل رساندن قرار گرفتن در معرض تابش و در عین حال حفظ کیفیت تصویر، از جمله 
             پروتکل‌های بهینه‌سازی دوز و تکنیک‌های جدید تصویربرداری مانند CT با دوز پایین، انجام می‌شود



";

        }
    }
}
