namespace formss
{
    partial class FormLoagin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUsernameLoagine = new System.Windows.Forms.TextBox();
            this.txtBoxPasswordLoagin = new System.Windows.Forms.TextBox();
            this.btnLoagin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 53);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(420, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "لطفا نام کاربری و رمز عبوری که در زمان ثبت نام انتخاب کرده اید را در این قسمت وار" +
    "د کنید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام کاربری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "رمز عبور";
            // 
            // txtBoxUsernameLoagine
            // 
            this.txtBoxUsernameLoagine.Location = new System.Drawing.Point(328, 154);
            this.txtBoxUsernameLoagine.Name = "txtBoxUsernameLoagine";
            this.txtBoxUsernameLoagine.Size = new System.Drawing.Size(147, 20);
            this.txtBoxUsernameLoagine.TabIndex = 3;
            // 
            // txtBoxPasswordLoagin
            // 
            this.txtBoxPasswordLoagin.Location = new System.Drawing.Point(328, 222);
            this.txtBoxPasswordLoagin.Name = "txtBoxPasswordLoagin";
            this.txtBoxPasswordLoagin.Size = new System.Drawing.Size(147, 20);
            this.txtBoxPasswordLoagin.TabIndex = 4;
            // 
            // btnLoagin
            // 
            this.btnLoagin.BackColor = System.Drawing.Color.DeepPink;
            this.btnLoagin.Location = new System.Drawing.Point(352, 408);
            this.btnLoagin.Name = "btnLoagin";
            this.btnLoagin.Size = new System.Drawing.Size(107, 34);
            this.btnLoagin.TabIndex = 5;
            this.btnLoagin.Text = "ورود";
            this.btnLoagin.UseVisualStyleBackColor = false;
            this.btnLoagin.Click += new System.EventHandler(this.btnLoagin_Click);
            // 
            // FormLoagin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(803, 478);
            this.Controls.Add(this.btnLoagin);
            this.Controls.Add(this.txtBoxPasswordLoagin);
            this.Controls.Add(this.txtBoxUsernameLoagine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLoagin";
            this.Text = "FormLoagin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUsernameLoagine;
        private System.Windows.Forms.TextBox txtBoxPasswordLoagin;
        private System.Windows.Forms.Button btnLoagin;
    }
}