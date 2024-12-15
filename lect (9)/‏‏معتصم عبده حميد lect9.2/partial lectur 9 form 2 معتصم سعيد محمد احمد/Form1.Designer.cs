namespace partial_lecture_9_form_2_معتصم_عبده_حميد_يحيى
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
            this.btn_remov = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_remove_all = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.radio_wmal = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.list_number = new System.Windows.Forms.ListBox();
            this.list_name = new System.Windows.Forms.ListBox();
            this.list_age = new System.Windows.Forms.ListBox();
            this.list_six = new System.Windows.Forms.ListBox();
            this.btn_clearselected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_remov
            // 
            this.btn_remov.BackColor = System.Drawing.Color.Gold;
            this.btn_remov.Location = new System.Drawing.Point(539, 137);
            this.btn_remov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remov.Name = "btn_remov";
            this.btn_remov.Size = new System.Drawing.Size(64, 21);
            this.btn_remov.TabIndex = 0;
            this.btn_remov.Text = "حذف";
            this.btn_remov.UseVisualStyleBackColor = false;
            this.btn_remov.Click += new System.EventHandler(this.btn_remov_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "الرقم";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(411, 62);
            this.txt_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(97, 20);
            this.txt_number.TabIndex = 2;
            this.txt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "الجنس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "العمر";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "الاسم";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.Location = new System.Drawing.Point(540, 190);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(64, 25);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_remove_all
            // 
            this.btn_remove_all.BackColor = System.Drawing.Color.Gold;
            this.btn_remove_all.Location = new System.Drawing.Point(540, 162);
            this.btn_remove_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove_all.Name = "btn_remove_all";
            this.btn_remove_all.Size = new System.Drawing.Size(64, 24);
            this.btn_remove_all.TabIndex = 8;
            this.btn_remove_all.Text = "حذف الكل";
            this.btn_remove_all.UseVisualStyleBackColor = false;
            this.btn_remove_all.Click += new System.EventHandler(this.btn_remove_all_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gold;
            this.btn_add.Location = new System.Drawing.Point(539, 107);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 27);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(137, 58);
            this.txt_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(107, 20);
            this.txt_age.TabIndex = 10;
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(272, 62);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(103, 20);
            this.txt_name.TabIndex = 11;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(29, 233);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(64, 29);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // radio_wmal
            // 
            this.radio_wmal.AutoSize = true;
            this.radio_wmal.Location = new System.Drawing.Point(63, 54);
            this.radio_wmal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_wmal.Name = "radio_wmal";
            this.radio_wmal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radio_wmal.Size = new System.Drawing.Size(46, 17);
            this.radio_wmal.TabIndex = 18;
            this.radio_wmal.TabStop = true;
            this.radio_wmal.Text = "انثى";
            this.radio_wmal.UseVisualStyleBackColor = true;
            this.radio_wmal.CheckedChanged += new System.EventHandler(this.radio_wmal_CheckedChanged);
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(69, 76);
            this.radio_male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_male.Name = "radio_male";
            this.radio_male.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radio_male.Size = new System.Drawing.Size(40, 17);
            this.radio_male.TabIndex = 19;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "ذكر";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(365, 314);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(55, 21);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "انثى";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(112, 106);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(49, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ذكر";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // list_number
            // 
            this.list_number.FormattingEnabled = true;
            this.list_number.Location = new System.Drawing.Point(411, 107);
            this.list_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_number.Name = "list_number";
            this.list_number.Size = new System.Drawing.Size(103, 108);
            this.list_number.TabIndex = 20;
            this.list_number.SelectedIndexChanged += new System.EventHandler(this.list_number_SelectedIndexChanged);
            // 
            // list_name
            // 
            this.list_name.FormattingEnabled = true;
            this.list_name.Location = new System.Drawing.Point(272, 107);
            this.list_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_name.Name = "list_name";
            this.list_name.Size = new System.Drawing.Size(103, 108);
            this.list_name.TabIndex = 21;
            this.list_name.SelectedIndexChanged += new System.EventHandler(this.list_name_SelectedIndexChanged);
            // 
            // list_age
            // 
            this.list_age.FormattingEnabled = true;
            this.list_age.Location = new System.Drawing.Point(137, 107);
            this.list_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_age.Name = "list_age";
            this.list_age.Size = new System.Drawing.Size(103, 108);
            this.list_age.TabIndex = 22;
            this.list_age.SelectedIndexChanged += new System.EventHandler(this.list_age_SelectedIndexChanged);
            // 
            // list_six
            // 
            this.list_six.FormattingEnabled = true;
            this.list_six.Location = new System.Drawing.Point(29, 107);
            this.list_six.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_six.Name = "list_six";
            this.list_six.Size = new System.Drawing.Size(103, 108);
            this.list_six.TabIndex = 23;
            this.list_six.SelectedIndexChanged += new System.EventHandler(this.list_six_SelectedIndexChanged);
            // 
            // btn_clearselected
            // 
            this.btn_clearselected.BackColor = System.Drawing.Color.Gold;
            this.btn_clearselected.Location = new System.Drawing.Point(511, 233);
            this.btn_clearselected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clearselected.Name = "btn_clearselected";
            this.btn_clearselected.Size = new System.Drawing.Size(92, 26);
            this.btn_clearselected.TabIndex = 24;
            this.btn_clearselected.Text = "حذف التظليل";
            this.btn_clearselected.UseVisualStyleBackColor = false;
            this.btn_clearselected.Click += new System.EventHandler(this.btn_clearselected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(621, 291);
            this.Controls.Add(this.btn_clearselected);
            this.Controls.Add(this.list_six);
            this.Controls.Add(this.list_age);
            this.Controls.Add(this.list_name);
            this.Controls.Add(this.list_number);
            this.Controls.Add(this.radio_male);
            this.Controls.Add(this.radio_wmal);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove_all);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remov);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "windows form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_remove_all;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btn_clearselected;
        public System.Windows.Forms.TextBox txt_number;
        public System.Windows.Forms.TextBox txt_age;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.RadioButton radio_wmal;
        public System.Windows.Forms.RadioButton radio_male;
        public System.Windows.Forms.ListBox list_number;
        public System.Windows.Forms.ListBox list_name;
        public System.Windows.Forms.ListBox list_age;
        public System.Windows.Forms.ListBox list_six;
    }
}

