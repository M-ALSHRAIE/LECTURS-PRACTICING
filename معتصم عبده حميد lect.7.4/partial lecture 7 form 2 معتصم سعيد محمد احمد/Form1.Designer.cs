namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.btn_updat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gold;
            this.btn_cancel.Location = new System.Drawing.Point(305, 110);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(73, 32);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "رجوع";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gold;
            this.btn_add.Location = new System.Drawing.Point(305, 53);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 38);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافه";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(131, 94);
            this.list1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(158, 134);
            this.list1.TabIndex = 2;
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(131, 53);
            this.txt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(158, 20);
            this.txt_add.TabIndex = 3;
            this.txt_add.TextChanged += new System.EventHandler(this.txt_add_TextChanged);
            // 
            // btn_updat
            // 
            this.btn_updat.BackColor = System.Drawing.Color.Gold;
            this.btn_updat.Location = new System.Drawing.Point(52, 54);
            this.btn_updat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_updat.Name = "btn_updat";
            this.btn_updat.Size = new System.Drawing.Size(70, 37);
            this.btn_updat.TabIndex = 4;
            this.btn_updat.Text = "تعديل";
            this.btn_updat.UseVisualStyleBackColor = false;
            this.btn_updat.Click += new System.EventHandler(this.btn_updat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(431, 265);
            this.Controls.Add(this.btn_updat);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Button btn_updat;
    }
}

