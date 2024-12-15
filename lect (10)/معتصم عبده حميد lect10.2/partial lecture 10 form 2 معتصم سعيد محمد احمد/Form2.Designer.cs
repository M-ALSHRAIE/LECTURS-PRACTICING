namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.data_birthday = new System.Windows.Forms.DateTimePicker();
            this.image_student = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name_ste = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_close = new System.Windows.Forms.Button();
            this.check_imag = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.image_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الطالب";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(461, 237);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 33);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // data_birthday
            // 
            this.data_birthday.Location = new System.Drawing.Point(277, 152);
            this.data_birthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_birthday.Name = "data_birthday";
            this.data_birthday.Size = new System.Drawing.Size(172, 20);
            this.data_birthday.TabIndex = 2;
            // 
            // image_student
            // 
            this.image_student.Location = new System.Drawing.Point(36, 32);
            this.image_student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image_student.Name = "image_student";
            this.image_student.Size = new System.Drawing.Size(172, 156);
            this.image_student.TabIndex = 3;
            this.image_student.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "تاريخ الميلاد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "اسم الطالب";
            // 
            // txt_name_ste
            // 
            this.txt_name_ste.Location = new System.Drawing.Point(277, 103);
            this.txt_name_ste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name_ste.Name = "txt_name_ste";
            this.txt_name_ste.Size = new System.Drawing.Size(172, 20);
            this.txt_name_ste.TabIndex = 7;
            this.txt_name_ste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_ste_KeyPress);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(277, 50);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(171, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(36, 237);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(80, 33);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // check_imag
            // 
            this.check_imag.AutoSize = true;
            this.check_imag.Location = new System.Drawing.Point(103, 208);
            this.check_imag.Name = "check_imag";
            this.check_imag.Size = new System.Drawing.Size(58, 13);
            this.check_imag.TabIndex = 10;
            this.check_imag.TabStop = true;
            this.check_imag.Text = "اختيار صوره";
            this.check_imag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.check_imag_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(599, 312);
            this.Controls.Add(this.check_imag);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txt_name_ste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.image_student);
            this.Controls.Add(this.data_birthday);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker data_birthday;
        private System.Windows.Forms.PictureBox image_student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name_ste;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.LinkLabel check_imag;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}