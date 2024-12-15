namespace partial_lecture_8_form_3_معتصم_عبده_حميد_يحيى
{
    partial class Form1
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.txt_av = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_clear_all = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_avg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gold;
            this.btn_add.Location = new System.Drawing.Point(184, 28);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(46, 28);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(31, 28);
            this.txt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(145, 20);
            this.txt_add.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 60);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 121);
            this.listBox1.TabIndex = 2;
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(31, 225);
            this.txt_sum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(145, 20);
            this.txt_sum.TabIndex = 3;
            // 
            // txt_av
            // 
            this.txt_av.Location = new System.Drawing.Point(31, 252);
            this.txt_av.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_av.Name = "txt_av";
            this.txt_av.Size = new System.Drawing.Size(145, 20);
            this.txt_av.TabIndex = 4;
            this.txt_av.TextChanged += new System.EventHandler(this.txt_av_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Gold;
            this.btn_clear.Location = new System.Drawing.Point(184, 193);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(50, 28);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "حذف";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_all.Location = new System.Drawing.Point(31, 193);
            this.btn_clear_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(145, 28);
            this.btn_clear_all.TabIndex = 6;
            this.btn_clear_all.Text = "حذف الكل";
            this.btn_clear_all.UseVisualStyleBackColor = false;
            // 
            // btn_sum
            // 
            this.btn_sum.BackColor = System.Drawing.Color.Gold;
            this.btn_sum.Location = new System.Drawing.Point(184, 225);
            this.btn_sum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(50, 20);
            this.btn_sum.TabIndex = 7;
            this.btn_sum.Text = "المجموع";
            this.btn_sum.UseVisualStyleBackColor = false;
            // 
            // btn_avg
            // 
            this.btn_avg.BackColor = System.Drawing.Color.Gold;
            this.btn_avg.Location = new System.Drawing.Point(184, 252);
            this.btn_avg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_avg.Name = "btn_avg";
            this.btn_avg.Size = new System.Drawing.Size(50, 20);
            this.btn_avg.TabIndex = 8;
            this.btn_avg.Text = "المعدل";
            this.btn_avg.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(272, 300);
            this.Controls.Add(this.btn_avg);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_av);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.TextBox txt_av;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_clear_all;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_avg;
    }
}

