namespace partial_lecture_7_form_3_معتصم_عبده_حميد_يحيى
{
    partial class sub
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_num2_sub = new System.Windows.Forms.TextBox();
            this.txt_result_sub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num1_sub = new System.Windows.Forms.TextBox();
            this.btn_cals_sub = new System.Windows.Forms.Button();
            this.btn_clear_sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "الناتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "العدد الثاني";
            // 
            // txt_num2_sub
            // 
            this.txt_num2_sub.Location = new System.Drawing.Point(25, 74);
            this.txt_num2_sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num2_sub.Name = "txt_num2_sub";
            this.txt_num2_sub.Size = new System.Drawing.Size(121, 20);
            this.txt_num2_sub.TabIndex = 11;
            // 
            // txt_result_sub
            // 
            this.txt_result_sub.Location = new System.Drawing.Point(25, 115);
            this.txt_result_sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_result_sub.Name = "txt_result_sub";
            this.txt_result_sub.Size = new System.Drawing.Size(121, 20);
            this.txt_result_sub.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "العدد الاول";
            // 
            // txt_num1_sub
            // 
            this.txt_num1_sub.Location = new System.Drawing.Point(25, 28);
            this.txt_num1_sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num1_sub.Name = "txt_num1_sub";
            this.txt_num1_sub.Size = new System.Drawing.Size(121, 20);
            this.txt_num1_sub.TabIndex = 8;
            // 
            // btn_cals_sub
            // 
            this.btn_cals_sub.BackColor = System.Drawing.Color.Gold;
            this.btn_cals_sub.Location = new System.Drawing.Point(25, 150);
            this.btn_cals_sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cals_sub.Name = "btn_cals_sub";
            this.btn_cals_sub.Size = new System.Drawing.Size(218, 27);
            this.btn_cals_sub.TabIndex = 7;
            this.btn_cals_sub.Text = "حساب";
            this.btn_cals_sub.UseVisualStyleBackColor = false;
            this.btn_cals_sub.Click += new System.EventHandler(this.btn_cals_sub_Click);
            // 
            // btn_clear_sub
            // 
            this.btn_clear_sub.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_sub.Location = new System.Drawing.Point(25, 181);
            this.btn_clear_sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_sub.Name = "btn_clear_sub";
            this.btn_clear_sub.Size = new System.Drawing.Size(218, 26);
            this.btn_clear_sub.TabIndex = 15;
            this.btn_clear_sub.Text = "حذف";
            this.btn_clear_sub.UseVisualStyleBackColor = false;
            this.btn_clear_sub.Click += new System.EventHandler(this.btn_clear_sub_Click);
            // 
            // sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(268, 218);
            this.Controls.Add(this.btn_clear_sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num2_sub);
            this.Controls.Add(this.txt_result_sub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num1_sub);
            this.Controls.Add(this.btn_cals_sub);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sub";
            this.Text = "sub";
            this.Load += new System.EventHandler(this.sub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_num2_sub;
        private System.Windows.Forms.TextBox txt_result_sub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num1_sub;
        private System.Windows.Forms.Button btn_cals_sub;
        private System.Windows.Forms.Button btn_clear_sub;
    }
}