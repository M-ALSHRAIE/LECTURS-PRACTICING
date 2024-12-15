namespace partial_lecture_9_form_2_معتصم_عبده_حميد_يحيى
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
            this.radio_malee = new System.Windows.Forms.RadioButton();
            this.radio_wmall = new System.Windows.Forms.RadioButton();
            this.txt_namee = new System.Windows.Forms.TextBox();
            this.txt_agee = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numberr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_malee
            // 
            this.radio_malee.AutoSize = true;
            this.radio_malee.Location = new System.Drawing.Point(91, 109);
            this.radio_malee.Name = "radio_malee";
            this.radio_malee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radio_malee.Size = new System.Drawing.Size(49, 21);
            this.radio_malee.TabIndex = 29;
            this.radio_malee.TabStop = true;
            this.radio_malee.Text = "ذكر";
            this.radio_malee.UseVisualStyleBackColor = true;
            // 
            // radio_wmall
            // 
            this.radio_wmall.AutoSize = true;
            this.radio_wmall.Location = new System.Drawing.Point(85, 82);
            this.radio_wmall.Name = "radio_wmall";
            this.radio_wmall.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radio_wmall.Size = new System.Drawing.Size(55, 21);
            this.radio_wmall.TabIndex = 28;
            this.radio_wmall.TabStop = true;
            this.radio_wmall.Text = "انثى";
            this.radio_wmall.UseVisualStyleBackColor = true;
            // 
            // txt_namee
            // 
            this.txt_namee.Location = new System.Drawing.Point(328, 92);
            this.txt_namee.Name = "txt_namee";
            this.txt_namee.Size = new System.Drawing.Size(120, 24);
            this.txt_namee.TabIndex = 27;
            // 
            // txt_agee
            // 
            this.txt_agee.Location = new System.Drawing.Point(171, 88);
            this.txt_agee.Name = "txt_agee";
            this.txt_agee.Size = new System.Drawing.Size(124, 24);
            this.txt_agee.TabIndex = 26;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(431, 158);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 42);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "الاسم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "العمر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "الجنس";
            // 
            // txt_numberr
            // 
            this.txt_numberr.Location = new System.Drawing.Point(490, 92);
            this.txt_numberr.Name = "txt_numberr";
            this.txt_numberr.Size = new System.Drawing.Size(113, 24);
            this.txt_numberr.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "الرقم";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(651, 89);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.radio_malee);
            this.Controls.Add(this.radio_wmall);
            this.Controls.Add(this.txt_namee);
            this.Controls.Add(this.txt_agee);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numberr);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_malee;
        private System.Windows.Forms.RadioButton radio_wmall;
        private System.Windows.Forms.TextBox txt_namee;
        private System.Windows.Forms.TextBox txt_agee;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numberr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
    }
}