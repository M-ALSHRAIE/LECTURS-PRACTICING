namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
{
    partial class Form3
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
            this.list_num_ste = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.list_name_ste = new System.Windows.Forms.ListBox();
            this.list_datbirthday_ste = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الطالب";
            // 
            // list_num_ste
            // 
            this.list_num_ste.BackColor = System.Drawing.SystemColors.Info;
            this.list_num_ste.FormattingEnabled = true;
            this.list_num_ste.Location = new System.Drawing.Point(528, 97);
            this.list_num_ste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_num_ste.Name = "list_num_ste";
            this.list_num_ste.Size = new System.Drawing.Size(127, 199);
            this.list_num_ste.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 199);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Gold;
            this.btn_clear.Location = new System.Drawing.Point(528, 319);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 36);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "حذف";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "تاريخ الميلاد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسم الطالب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "صورة الطالب";
            // 
            // list_name_ste
            // 
            this.list_name_ste.BackColor = System.Drawing.SystemColors.Info;
            this.list_name_ste.FormattingEnabled = true;
            this.list_name_ste.Location = new System.Drawing.Point(384, 97);
            this.list_name_ste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_name_ste.Name = "list_name_ste";
            this.list_name_ste.Size = new System.Drawing.Size(127, 199);
            this.list_name_ste.TabIndex = 7;
            // 
            // list_datbirthday_ste
            // 
            this.list_datbirthday_ste.BackColor = System.Drawing.SystemColors.Info;
            this.list_datbirthday_ste.FormattingEnabled = true;
            this.list_datbirthday_ste.Location = new System.Drawing.Point(237, 97);
            this.list_datbirthday_ste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_datbirthday_ste.Name = "list_datbirthday_ste";
            this.list_datbirthday_ste.Size = new System.Drawing.Size(127, 199);
            this.list_datbirthday_ste.TabIndex = 9;
            this.list_datbirthday_ste.SelectedIndexChanged += new System.EventHandler(this.list_datbirthday_ste_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Gold;
            this.btn_close.Location = new System.Drawing.Point(57, 320);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(127, 36);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "اغلاق";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Gold;
            this.btn_update.Location = new System.Drawing.Point(260, 319);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(127, 36);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Gold;
            this.btn_refresh.Location = new System.Drawing.Point(393, 319);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(127, 36);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "تحديث";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(698, 366);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.list_datbirthday_ste);
            this.Controls.Add(this.list_name_ste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list_num_ste);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_num_ste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox list_name_ste;
        private System.Windows.Forms.ListBox list_datbirthday_ste;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_refresh;
    }
}