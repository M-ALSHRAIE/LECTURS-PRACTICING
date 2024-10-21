namespace المحاضره_الثالثه_الشكل_الاول
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.math = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.oper2 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.oper1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clos
            // 
            this.clos.BackColor = System.Drawing.SystemColors.Highlight;
            this.clos.Location = new System.Drawing.Point(29, 278);
            this.clos.Name = "clos";
            this.clos.Size = new System.Drawing.Size(75, 23);
            this.clos.TabIndex = 0;
            this.clos.Text = "اغلاق";
            this.clos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "العدد الاول";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(29, 47);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 20);
            this.num1.TabIndex = 2;
            this.num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num1_KeyPress);
            // 
            // math
            // 
            this.math.BackColor = System.Drawing.SystemColors.Highlight;
            this.math.Location = new System.Drawing.Point(188, 278);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(75, 23);
            this.math.TabIndex = 3;
            this.math.Text = "حساب";
            this.math.UseVisualStyleBackColor = false;
            this.math.Click += new System.EventHandler(this.Math_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(29, 235);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 4;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(29, 196);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(100, 20);
            this.num3.TabIndex = 5;
            this.num3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num3_KeyPress);
            // 
            // oper2
            // 
            this.oper2.Location = new System.Drawing.Point(29, 159);
            this.oper2.Name = "oper2";
            this.oper2.Size = new System.Drawing.Size(100, 20);
            this.oper2.TabIndex = 6;
            this.oper2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Oper2_KeyPress);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(29, 126);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 7;
            this.num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num2_KeyPress);
            // 
            // oper1
            // 
            this.oper1.Location = new System.Drawing.Point(29, 85);
            this.oper1.Name = "oper1";
            this.oper1.Size = new System.Drawing.Size(100, 20);
            this.oper1.TabIndex = 8;
            this.oper1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Oper1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "العمليه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "العدد الثاني";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "العدد الثالث";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "الناتج";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "العمليه";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oper1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.oper2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.math);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clos);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(289, 325);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Button math;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox oper2;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox oper1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
