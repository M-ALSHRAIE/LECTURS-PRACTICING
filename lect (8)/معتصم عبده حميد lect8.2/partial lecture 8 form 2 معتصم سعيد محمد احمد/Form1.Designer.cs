namespace partial_lecture_8_form_2_معتصم_عبده_حميد_يحيى
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
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_clear_txt1 = new System.Windows.Forms.Button();
            this.btn_clear_text2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.Gold;
            this.btn_copy.Location = new System.Drawing.Point(224, 34);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(64, 25);
            this.btn_copy.TabIndex = 1;
            this.btn_copy.Text = "نسخ";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.BackColor = System.Drawing.Color.Gold;
            this.btn_cut.Location = new System.Drawing.Point(224, 63);
            this.btn_cut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(64, 25);
            this.btn_cut.TabIndex = 2;
            this.btn_cut.Text = "قص";
            this.btn_cut.UseVisualStyleBackColor = false;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.BackColor = System.Drawing.Color.Gold;
            this.btn_paste.Location = new System.Drawing.Point(224, 134);
            this.btn_paste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(64, 24);
            this.btn_paste.TabIndex = 3;
            this.btn_paste.Text = "لصق";
            this.btn_paste.UseVisualStyleBackColor = false;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.BackColor = System.Drawing.Color.Gold;
            this.btn_undo.Location = new System.Drawing.Point(224, 162);
            this.btn_undo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(64, 24);
            this.btn_undo.TabIndex = 4;
            this.btn_undo.Text = "تراجع";
            this.btn_undo.UseVisualStyleBackColor = false;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 78);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 89);
            this.textBox2.TabIndex = 6;
            // 
            // btn_clear_txt1
            // 
            this.btn_clear_txt1.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_txt1.Location = new System.Drawing.Point(224, 92);
            this.btn_clear_txt1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_txt1.Name = "btn_clear_txt1";
            this.btn_clear_txt1.Size = new System.Drawing.Size(64, 19);
            this.btn_clear_txt1.TabIndex = 8;
            this.btn_clear_txt1.Text = "حذف";
            this.btn_clear_txt1.UseVisualStyleBackColor = false;
            this.btn_clear_txt1.Click += new System.EventHandler(this.btn_clear_txt1_Click);
            // 
            // btn_clear_text2
            // 
            this.btn_clear_text2.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_text2.Location = new System.Drawing.Point(224, 190);
            this.btn_clear_text2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_text2.Name = "btn_clear_text2";
            this.btn_clear_text2.Size = new System.Drawing.Size(64, 33);
            this.btn_clear_text2.TabIndex = 9;
            this.btn_clear_text2.Text = "حذف";
            this.btn_clear_text2.UseVisualStyleBackColor = false;
            this.btn_clear_text2.Click += new System.EventHandler(this.btn_clear_text2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(332, 264);
            this.Controls.Add(this.btn_clear_text2);
            this.Controls.Add(this.btn_clear_txt1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.btn_paste);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.btn_copy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_clear_txt1;
        private System.Windows.Forms.Button btn_clear_text2;
    }
}

