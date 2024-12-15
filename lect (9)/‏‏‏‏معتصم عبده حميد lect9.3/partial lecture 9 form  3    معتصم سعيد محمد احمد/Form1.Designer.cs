namespacepartial_lecture_9_form_3_معتصم_عبده_حميد_يحيى
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_num1 = new System.Windows.Forms.ListBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear_all = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_clear_check = new System.Windows.Forms.Button();
            this.list_oper = new System.Windows.Forms.ListBox();
            this.list_num2 = new System.Windows.Forms.ListBox();
            this.list_result = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.combo_oper = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_clear.Location = new System.Drawing.Point(526, 191);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 40);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "حذف";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "العدد الاول";
            // 
            // list_num1
            // 
            this.list_num1.FormattingEnabled = true;
            this.list_num1.ItemHeight = 16;
            this.list_num1.Location = new System.Drawing.Point(392, 191);
            this.list_num1.Name = "list_num1";
            this.list_num1.Size = new System.Drawing.Size(100, 132);
            this.list_num1.TabIndex = 2;
            this.list_num1.SelectedIndexChanged += new System.EventHandler(this.list_num1_SelectedIndexChanged);
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(392, 94);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 24);
            this.txt_num1.TabIndex = 3;
            this.txt_num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "الناتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "العدد الثاني";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "العمليه";
            // 
            // txt_result
            // 
            this.txt_result.Enabled = false;
            this.txt_result.Location = new System.Drawing.Point(12, 93);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 24);
            this.txt_result.TabIndex = 7;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(141, 93);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 24);
            this.txt_num2.TabIndex = 8;
            this.txt_num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num1_KeyPress);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_close.Location = new System.Drawing.Point(12, 398);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(108, 40);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_update.Location = new System.Drawing.Point(526, 328);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 40);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_clear_all.Location = new System.Drawing.Point(526, 263);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(108, 40);
            this.btn_clear_all.TabIndex = 12;
            this.btn_clear_all.Text = "حذف الكل";
            this.btn_clear_all.UseVisualStyleBackColor = false;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_calc.Location = new System.Drawing.Point(209, 136);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(283, 40);
            this.btn_calc.TabIndex = 13;
            this.btn_calc.Text = "حساب";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_clear_check
            // 
            this.btn_clear_check.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_clear_check.Location = new System.Drawing.Point(526, 383);
            this.btn_clear_check.Name = "btn_clear_check";
            this.btn_clear_check.Size = new System.Drawing.Size(108, 40);
            this.btn_clear_check.TabIndex = 14;
            this.btn_clear_check.Text = "حذف التظليل";
            this.btn_clear_check.UseVisualStyleBackColor = false;
            this.btn_clear_check.Click += new System.EventHandler(this.btn_clear_check_Click);
            // 
            // list_oper
            // 
            this.list_oper.FormattingEnabled = true;
            this.list_oper.ItemHeight = 16;
            this.list_oper.Location = new System.Drawing.Point(266, 191);
            this.list_oper.Name = "list_oper";
            this.list_oper.Size = new System.Drawing.Size(107, 132);
            this.list_oper.TabIndex = 15;
            this.list_oper.SelectedIndexChanged += new System.EventHandler(this.list_oper_SelectedIndexChanged);
            // 
            // list_num2
            // 
            this.list_num2.FormattingEnabled = true;
            this.list_num2.ItemHeight = 16;
            this.list_num2.Location = new System.Drawing.Point(141, 191);
            this.list_num2.Name = "list_num2";
            this.list_num2.Size = new System.Drawing.Size(100, 132);
            this.list_num2.TabIndex = 16;
            this.list_num2.SelectedIndexChanged += new System.EventHandler(this.list_num2_SelectedIndexChanged);
            // 
            // list_result
            // 
            this.list_result.FormattingEnabled = true;
            this.list_result.ItemHeight = 16;
            this.list_result.Location = new System.Drawing.Point(12, 191);
            this.list_result.Name = "list_result";
            this.list_result.Size = new System.Drawing.Size(100, 132);
            this.list_result.TabIndex = 17;
            this.list_result.SelectedIndexChanged += new System.EventHandler(this.list_result_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_add.Location = new System.Drawing.Point(526, 127);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 40);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // combo_oper
            // 
            this.combo_oper.FormattingEnabled = true;
            this.combo_oper.Location = new System.Drawing.Point(266, 94);
            this.combo_oper.Name = "combo_oper";
            this.combo_oper.Size = new System.Drawing.Size(107, 24);
            this.combo_oper.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_oper);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.list_result);
            this.Controls.Add(this.list_num2);
            this.Controls.Add(this.list_oper);
            this.Controls.Add(this.btn_clear_check);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_clear_all);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.list_num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_num1;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear_all;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_clear_check;
        private System.Windows.Forms.ListBox list_oper;
        private System.Windows.Forms.ListBox list_num2;
        private System.Windows.Forms.ListBox list_result;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox combo_oper;
        private System.Windows.Forms.Label label5;
    }
}

