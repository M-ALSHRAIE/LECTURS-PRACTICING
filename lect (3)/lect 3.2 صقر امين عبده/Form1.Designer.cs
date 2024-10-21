namespace lect_3._2_معتصم_عبده_حميد
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
            this.btnchick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnred = new System.Windows.Forms.Button();
            this.btnyelow = new System.Windows.Forms.Button();
            this.btngren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnchick
            // 
            this.btnchick.Location = new System.Drawing.Point(151, 119);
            this.btnchick.Name = "btnchick";
            this.btnchick.Size = new System.Drawing.Size(75, 30);
            this.btnchick.TabIndex = 0;
            this.btnchick.Text = "تحقق";
            this.btnchick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الجهاز الاول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "الجهاز الثاني";
            // 
            // btnred
            // 
            this.btnred.BackColor = System.Drawing.Color.Crimson;
            this.btnred.Location = new System.Drawing.Point(248, 69);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(75, 30);
            this.btnred.TabIndex = 6;
            this.btnred.Text = "احمر";
            this.btnred.UseVisualStyleBackColor = false;
            this.btnred.Click += new System.EventHandler(this.Btnred_Click_1);
            // 
            // btnyelow
            // 
            this.btnyelow.BackColor = System.Drawing.Color.Gold;
            this.btnyelow.Location = new System.Drawing.Point(151, 69);
            this.btnyelow.Name = "btnyelow";
            this.btnyelow.Size = new System.Drawing.Size(75, 30);
            this.btnyelow.TabIndex = 7;
            this.btnyelow.Text = "اصفر";
            this.btnyelow.UseVisualStyleBackColor = false;
            this.btnyelow.Click += new System.EventHandler(this.Btnyelow_Click);
            // 
            // btngren
            // 
            this.btngren.BackColor = System.Drawing.Color.DarkGreen;
            this.btngren.Location = new System.Drawing.Point(54, 69);
            this.btngren.Name = "btngren";
            this.btngren.Size = new System.Drawing.Size(75, 30);
            this.btngren.TabIndex = 8;
            this.btngren.Text = "اخضر";
            this.btngren.UseVisualStyleBackColor = false;
            this.btngren.Click += new System.EventHandler(this.Btngren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(383, 175);
            this.Controls.Add(this.btngren);
            this.Controls.Add(this.btnyelow);
            this.Controls.Add(this.btnred);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnred;
        private System.Windows.Forms.Button btnyelow;
        private System.Windows.Forms.Button btngren;
    }
}

