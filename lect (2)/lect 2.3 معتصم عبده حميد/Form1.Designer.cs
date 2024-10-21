namespace lect_2._3_معتصم_عبده_حميد
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "العدد الاول ";
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(237, 102);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(75, 23);
            this.btn_sum.TabIndex = 1;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.Btn_sum_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Yellow;
            this.textBox3.Location = new System.Drawing.Point(33, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "العدد الثاني";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "الناتج";
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(145, 102);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(75, 23);
            this.btn_min.TabIndex = 7;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(145, 134);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 8;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(237, 134);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(75, 23);
            this.btn_mult.TabIndex = 9;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_del.Location = new System.Drawing.Point(33, 102);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "حذف";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.BackColor = System.Drawing.Color.Crimson;
            this.btn_cls.Location = new System.Drawing.Point(33, 133);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(75, 23);
            this.btn_cls.TabIndex = 11;
            this.btn_cls.Text = "اغلاق";
            this.btn_cls.UseVisualStyleBackColor = false;
            this.btn_cls.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 187);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Label label4;
    }
}

