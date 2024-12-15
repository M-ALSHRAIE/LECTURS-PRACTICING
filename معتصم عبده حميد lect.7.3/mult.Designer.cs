namespace partial_lecture_7_form_3_معتصم_عبده_حميد_يحيى
{
    partial class mult
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
            this.btn_cals_mult = new System.Windows.Forms.Button();
            this.txt_num1_mult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_result_mult = new System.Windows.Forms.TextBox();
            this.txt_num2_mult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_clear_mult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cals_mult
            // 
            this.btn_cals_mult.BackColor = System.Drawing.Color.Gold;
            this.btn_cals_mult.Location = new System.Drawing.Point(42, 157);
            this.btn_cals_mult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cals_mult.Name = "btn_cals_mult";
            this.btn_cals_mult.Size = new System.Drawing.Size(219, 24);
            this.btn_cals_mult.TabIndex = 0;
            this.btn_cals_mult.Text = "حساب";
            this.btn_cals_mult.UseVisualStyleBackColor = false;
            this.btn_cals_mult.Click += new System.EventHandler(this.btn_cals_mult_Click);
            // 
            // txt_num1_mult
            // 
            this.txt_num1_mult.Location = new System.Drawing.Point(42, 33);
            this.txt_num1_mult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num1_mult.Name = "txt_num1_mult";
            this.txt_num1_mult.Size = new System.Drawing.Size(121, 20);
            this.txt_num1_mult.TabIndex = 1;
            this.txt_num1_mult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num1_mult_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(201, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "العدد الاول";
            // 
            // txt_result_mult
            // 
            this.txt_result_mult.Location = new System.Drawing.Point(42, 120);
            this.txt_result_mult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_result_mult.Name = "txt_result_mult";
            this.txt_result_mult.Size = new System.Drawing.Size(121, 20);
            this.txt_result_mult.TabIndex = 3;
            // 
            // txt_num2_mult
            // 
            this.txt_num2_mult.Location = new System.Drawing.Point(42, 79);
            this.txt_num2_mult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num2_mult.Name = "txt_num2_mult";
            this.txt_num2_mult.Size = new System.Drawing.Size(121, 20);
            this.txt_num2_mult.TabIndex = 4;
            this.txt_num2_mult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num1_mult_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(201, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "العدد الثاني";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(211, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "الناتج";
            // 
            // btn_clear_mult
            // 
            this.btn_clear_mult.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_mult.Location = new System.Drawing.Point(42, 185);
            this.btn_clear_mult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_mult.Name = "btn_clear_mult";
            this.btn_clear_mult.Size = new System.Drawing.Size(219, 28);
            this.btn_clear_mult.TabIndex = 15;
            this.btn_clear_mult.Text = "حذف";
            this.btn_clear_mult.UseVisualStyleBackColor = false;
            this.btn_clear_mult.Click += new System.EventHandler(this.btn_clear_mult_Click);
            // 
            // mult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(302, 248);
            this.Controls.Add(this.btn_clear_mult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num2_mult);
            this.Controls.Add(this.txt_result_mult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num1_mult);
            this.Controls.Add(this.btn_cals_mult);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mult";
            this.Text = "mult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cals_mult;
        private System.Windows.Forms.TextBox txt_num1_mult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_result_mult;
        private System.Windows.Forms.TextBox txt_num2_mult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clear_mult;
    }
}