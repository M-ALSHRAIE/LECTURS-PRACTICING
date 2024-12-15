namespace partial_lecture_7_form_3_معتصم_عبده_حميد_يحيى
{
    partial class div
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
            this.txt_num2_div = new System.Windows.Forms.TextBox();
            this.txt_result_div = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num1_div = new System.Windows.Forms.TextBox();
            this.btn_cals_div = new System.Windows.Forms.Button();
            this.btn_clear_div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(216, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "الناتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(205, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "العدد الثاني";
            // 
            // txt_num2_div
            // 
            this.txt_num2_div.Location = new System.Drawing.Point(47, 82);
            this.txt_num2_div.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num2_div.Name = "txt_num2_div";
            this.txt_num2_div.Size = new System.Drawing.Size(121, 20);
            this.txt_num2_div.TabIndex = 11;
            // 
            // txt_result_div
            // 
            this.txt_result_div.Location = new System.Drawing.Point(47, 122);
            this.txt_result_div.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_result_div.Name = "txt_result_div";
            this.txt_result_div.Size = new System.Drawing.Size(121, 20);
            this.txt_result_div.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(205, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "العدد الاول";
            // 
            // txt_num1_div
            // 
            this.txt_num1_div.Location = new System.Drawing.Point(47, 36);
            this.txt_num1_div.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num1_div.Name = "txt_num1_div";
            this.txt_num1_div.Size = new System.Drawing.Size(121, 20);
            this.txt_num1_div.TabIndex = 8;
            this.txt_num1_div.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num1_div_KeyPress);
            // 
            // btn_cals_div
            // 
            this.btn_cals_div.BackColor = System.Drawing.Color.Gold;
            this.btn_cals_div.Location = new System.Drawing.Point(47, 157);
            this.btn_cals_div.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cals_div.Name = "btn_cals_div";
            this.btn_cals_div.Size = new System.Drawing.Size(218, 21);
            this.btn_cals_div.TabIndex = 7;
            this.btn_cals_div.Text = "حساب";
            this.btn_cals_div.UseVisualStyleBackColor = false;
            this.btn_cals_div.Click += new System.EventHandler(this.btn_cals_div_Click);
            // 
            // btn_clear_div
            // 
            this.btn_clear_div.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_div.Location = new System.Drawing.Point(47, 182);
            this.btn_clear_div.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_div.Name = "btn_clear_div";
            this.btn_clear_div.Size = new System.Drawing.Size(218, 24);
            this.btn_clear_div.TabIndex = 14;
            this.btn_clear_div.Text = "حذف";
            this.btn_clear_div.UseVisualStyleBackColor = false;
            this.btn_clear_div.Click += new System.EventHandler(this.btn_clear_div_Click);
            // 
            // div
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(305, 234);
            this.Controls.Add(this.btn_clear_div);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num2_div);
            this.Controls.Add(this.txt_result_div);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num1_div);
            this.Controls.Add(this.btn_cals_div);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "div";
            this.Text = "div";
            this.Load += new System.EventHandler(this.div_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_num2_div;
        private System.Windows.Forms.TextBox txt_result_div;
   //     private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num1_div;
        private System.Windows.Forms.Button btn_cals_div;
        private System.Windows.Forms.Button btn_clear_div;
    }
}