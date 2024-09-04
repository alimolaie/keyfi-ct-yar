using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formss
{
    public partial class FormLoagin : Form
    {

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=.;Initial Catalog=ct;Integrated Security=True;Trust Server Certificate=True");
            cn.Open();
        }
        public FormLoagin()
        {
            InitializeComponent();
        }

        private void btnLoagin_Click(object sender, EventArgs e)
        {
            if (txtBoxUsernameLoagine.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            // بررسی کنید که آیا فرم قبلاً باز نشده است
          
    }
}
