namespacepartial_lecture_9_form_3_معتصم_عبده_حميد_يحيى
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.combo_oper = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "=";
            // 
            // combo_oper
            // 
            this.combo_oper.FormattingEnabled = true;
            this.combo_oper.Location = new System.Drawing.Point(290, 133);
            this.combo_oper.Name = "combo_oper";
            this.combo_oper.Size = new System.Drawing.Size(107, 24);
            this.combo_oper.TabIndex = 29;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_save.Location = new System.Drawing.Point(36, 233);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(480, 40);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(165, 132);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 24);
            this.txt_num2.TabIndex = 27;
            // 
            // txt_result
            // 
            this.txt_result.Enabled = false;
            this.txt_result.Location = new System.Drawing.Point(36, 132);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 24);
            this.txt_result.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "العمليه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "العدد الثاني";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "الناتج";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(416, 133);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 24);
            this.txt_num1.TabIndex = 22;
            this.txt_num1.TextChanged += new System.EventHandler(this.txt_num1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "العدد الاول";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(290, 186);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(147, 23);
            this.btn_calc.TabIndex = 31;
            this.btn_calc.Text = "حساب";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 285);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_oper);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_oper;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calc;
    }
}