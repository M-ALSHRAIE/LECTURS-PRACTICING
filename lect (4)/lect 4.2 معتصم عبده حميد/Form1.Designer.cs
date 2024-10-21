namespace lect_4._2_معتصم_عبده_حميد
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_vew = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(49, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 95);
            this.listBox1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Yellow;
            this.btn_add.Location = new System.Drawing.Point(49, 60);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(225, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اظافه للمصفوفة";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ادخل عدد العناصر";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ادخل الرقم";
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Gold;
            this.btn_del.Location = new System.Drawing.Point(187, 235);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(86, 23);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "المجموع";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // btn_vew
            // 
            this.btn_vew.BackColor = System.Drawing.Color.Gold;
            this.btn_vew.Location = new System.Drawing.Point(49, 106);
            this.btn_vew.Name = "btn_vew";
            this.btn_vew.Size = new System.Drawing.Size(112, 23);
            this.btn_vew.TabIndex = 7;
            this.btn_vew.Text = "عرض العناصر";
            this.btn_vew.UseVisualStyleBackColor = false;
            this.btn_vew.Click += new System.EventHandler(this.Btn_vew_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.BackColor = System.Drawing.Color.Gold;
            this.btn_sum.Location = new System.Drawing.Point(167, 106);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(107, 23);
            this.btn_sum.TabIndex = 8;
            this.btn_sum.Text = "حذف العناصر";
            this.btn_sum.UseVisualStyleBackColor = false;
            this.btn_sum.Click += new System.EventHandler(this.Btn_sum_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(330, 285);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_vew);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_vew;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.TextBox textBox3;
    }
}

