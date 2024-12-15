namespace partial_lecture_7_form_3_معتصم_عبده_حميد_يحيى
{
    partial class add
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
            this.txt_num2_add = new System.Windows.Forms.TextBox();
            this.txt_result_add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num1_add = new System.Windows.Forms.TextBox();
            this.btn_cals_add = new System.Windows.Forms.Button();
            this.btn_clear_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "الناتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "العدد الثاني";
            // 
            // txt_num2_add
            // 
            this.txt_num2_add.Location = new System.Drawing.Point(27, 76);
            this.txt_num2_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num2_add.Name = "txt_num2_add";
            this.txt_num2_add.Size = new System.Drawing.Size(121, 20);
            this.txt_num2_add.TabIndex = 11;
            this.txt_num2_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num1_add_KeyPress);
            // 
            // txt_result_add
            // 
            this.txt_result_add.Location = new System.Drawing.Point(27, 117);
            this.txt_result_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_result_add.Name = "txt_result_add";
            this.txt_result_add.Size = new System.Drawing.Size(121, 20);
            this.txt_result_add.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "العدد الاول";
            // 
            // txt_num1_add
            // 
            this.txt_num1_add.Location = new System.Drawing.Point(27, 30);
            this.txt_num1_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_num1_add.Name = "txt_num1_add";
            this.txt_num1_add.Size = new System.Drawing.Size(121, 20);
            this.txt_num1_add.TabIndex = 8;
            this.txt_num1_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num1_add_KeyPress);
            // 
            // btn_cals_add
            // 
            this.btn_cals_add.BackColor = System.Drawing.Color.Gold;
            this.btn_cals_add.Location = new System.Drawing.Point(27, 151);
            this.btn_cals_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cals_add.Name = "btn_cals_add";
            this.btn_cals_add.Size = new System.Drawing.Size(218, 19);
            this.btn_cals_add.TabIndex = 7;
            this.btn_cals_add.Text = "حساب";
            this.btn_cals_add.UseVisualStyleBackColor = false;
            this.btn_cals_add.Click += new System.EventHandler(this.btn_cals_add_Click);
            // 
            // btn_clear_add
            // 
            this.btn_clear_add.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_add.Location = new System.Drawing.Point(27, 174);
            this.btn_clear_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_add.Name = "btn_clear_add";
            this.btn_clear_add.Size = new System.Drawing.Size(218, 19);
            this.btn_clear_add.TabIndex = 15;
            this.btn_clear_add.Text = "حذف";
            this.btn_clear_add.UseVisualStyleBackColor = false;
            this.btn_clear_add.Click += new System.EventHandler(this.btn_clear_add_Click);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(270, 224);
            this.Controls.Add(this.btn_clear_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num2_add);
            this.Controls.Add(this.txt_result_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num1_add);
            this.Controls.Add(this.btn_cals_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "add";
            this.Text = "add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_num2_add;
        private System.Windows.Forms.TextBox txt_result_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num1_add;
        private System.Windows.Forms.Button btn_cals_add;
        private System.Windows.Forms.Button btn_clear_add;
    }
}