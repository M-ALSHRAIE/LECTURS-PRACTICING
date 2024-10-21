namespace lect_3._1_معتصم_عبده_حميد
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oper1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.oper2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.math = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "العمليه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "الناتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "العدد الثالث";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "العدد الثاني";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "العمليه";
            // 
            // oper1
            // 
            this.oper1.Location = new System.Drawing.Point(38, 59);
            this.oper1.Name = "oper1";
            this.oper1.Size = new System.Drawing.Size(100, 20);
            this.oper1.TabIndex = 22;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(38, 96);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 21;
            this.num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num2_KeyPress);
            // 
            // oper2
            // 
            this.oper2.Location = new System.Drawing.Point(38, 133);
            this.oper2.Name = "oper2";
            this.oper2.Size = new System.Drawing.Size(100, 20);
            this.oper2.TabIndex = 20;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(38, 170);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(100, 20);
            this.num3.TabIndex = 19;
            this.num3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num3_KeyPress);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(38, 206);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 18;
            // 
            // math
            // 
            this.math.BackColor = System.Drawing.Color.Orange;
            this.math.Location = new System.Drawing.Point(150, 242);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(75, 35);
            this.math.TabIndex = 17;
            this.math.Text = "حساب";
            this.math.UseVisualStyleBackColor = false;
            this.math.Click += new System.EventHandler(this.Math_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(38, 21);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 20);
            this.num1.TabIndex = 16;
            this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "العدد الاول";
            // 
            // clos
            // 
            this.clos.BackColor = System.Drawing.Color.Orange;
            this.clos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clos.Location = new System.Drawing.Point(38, 242);
            this.clos.Name = "clos";
            this.clos.Size = new System.Drawing.Size(75, 35);
            this.clos.TabIndex = 14;
            this.clos.Text = "اغلاق";
            this.clos.UseVisualStyleBackColor = false;
            this.clos.Click += new System.EventHandler(this.Clos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(260, 297);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اله حاسبـــــه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oper1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox oper2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button math;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clos;
    }
}

