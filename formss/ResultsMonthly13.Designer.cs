﻿namespace formss
{
    partial class ResultsMonthly13
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(1178, 693);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "تایید";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "آزمون های ماهانه _ آزمون صحت جا به جایی تخت";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "مقدار تنظیمی جا به جایی تخت بین اسلایس ها تحت بار";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "مقدار اندازه گیری شده در فیلم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "خطا";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 223);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 28);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 334);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 28);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(411, 440);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 28);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // ResultsMonthly13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ResultsMonthly13";
            this.Text = "کیفی سی تی یار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ResultsMonthly13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}