namespace lect_5._3_معتصم_عبده_حميد
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_forawod = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_forawod
            // 
            this.btn_forawod.BackColor = System.Drawing.Color.Gold;
            this.btn_forawod.Location = new System.Drawing.Point(289, 164);
            this.btn_forawod.Name = "btn_forawod";
            this.btn_forawod.Size = new System.Drawing.Size(75, 23);
            this.btn_forawod.TabIndex = 1;
            this.btn_forawod.Text = "التحرك للأمام";
            this.btn_forawod.UseVisualStyleBackColor = false;
            this.btn_forawod.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "V";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Gold;
            this.btn_down.Location = new System.Drawing.Point(289, 135);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 3;
            this.btn_down.Text = "الى أسفل";
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.Btn_down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(504, 266);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_forawod);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_forawod;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_down;
    }
}

