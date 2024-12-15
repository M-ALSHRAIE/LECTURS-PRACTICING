namespace partial_lecture_7_form_3_معتصم_عبده_حميد_يحيى
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
            this.components = new System.ComponentModel.Container();
            this.toll_division = new System.Windows.Forms.ToolStrip();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_substrat = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ضربToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جمعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طرحToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قسمهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toll_division
            // 
            this.toll_division.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toll_division.Location = new System.Drawing.Point(0, 24);
            this.toll_division.Name = "toll_division";
            this.toll_division.Size = new System.Drawing.Size(257, 25);
            this.toll_division.TabIndex = 2;
            // 
            // btn_addition
            // 
            this.btn_addition.BackColor = System.Drawing.Color.Gold;
            this.btn_addition.ForeColor = System.Drawing.Color.Teal;
            this.btn_addition.Location = new System.Drawing.Point(51, 67);
            this.btn_addition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(67, 39);
            this.btn_addition.TabIndex = 3;
            this.btn_addition.Text = "addition";
            this.btn_addition.UseVisualStyleBackColor = false;
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_substrat
            // 
            this.btn_substrat.BackColor = System.Drawing.Color.Gold;
            this.btn_substrat.ForeColor = System.Drawing.Color.Teal;
            this.btn_substrat.Location = new System.Drawing.Point(51, 110);
            this.btn_substrat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_substrat.Name = "btn_substrat";
            this.btn_substrat.Size = new System.Drawing.Size(148, 39);
            this.btn_substrat.TabIndex = 4;
            this.btn_substrat.Text = "substrat";
            this.btn_substrat.UseVisualStyleBackColor = false;
            this.btn_substrat.Click += new System.EventHandler(this.btn_substrat_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.BackColor = System.Drawing.Color.Gold;
            this.btn_multiply.ForeColor = System.Drawing.Color.Teal;
            this.btn_multiply.Location = new System.Drawing.Point(124, 67);
            this.btn_multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(75, 39);
            this.btn_multiply.TabIndex = 5;
            this.btn_multiply.Text = "multiply";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.Gold;
            this.btn_division.ForeColor = System.Drawing.Color.Teal;
            this.btn_division.Location = new System.Drawing.Point(51, 153);
            this.btn_division.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(148, 37);
            this.btn_division.TabIndex = 6;
            this.btn_division.Text = "division";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.subToolStripMenuItem,
            this.divToolStripMenuItem,
            this.multToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(257, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // subToolStripMenuItem
            // 
            this.subToolStripMenuItem.Name = "subToolStripMenuItem";
            this.subToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.subToolStripMenuItem.Text = "sub";
            this.subToolStripMenuItem.Click += new System.EventHandler(this.btn_substrat_Click);
            // 
            // divToolStripMenuItem
            // 
            this.divToolStripMenuItem.Name = "divToolStripMenuItem";
            this.divToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.divToolStripMenuItem.Text = "div";
            this.divToolStripMenuItem.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // multToolStripMenuItem
            // 
            this.multToolStripMenuItem.Name = "multToolStripMenuItem";
            this.multToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.multToolStripMenuItem.Text = "mult";
            this.multToolStripMenuItem.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ضربToolStripMenuItem,
            this.جمعToolStripMenuItem,
            this.طرحToolStripMenuItem,
            this.قسمهToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "العمليات";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ضربToolStripMenuItem
            // 
            this.ضربToolStripMenuItem.Name = "ضربToolStripMenuItem";
            this.ضربToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ضربToolStripMenuItem.Text = "addition";
            this.ضربToolStripMenuItem.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // جمعToolStripMenuItem
            // 
            this.جمعToolStripMenuItem.Name = "جمعToolStripMenuItem";
            this.جمعToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.جمعToolStripMenuItem.Text = "substrat";
            this.جمعToolStripMenuItem.Click += new System.EventHandler(this.btn_substrat_Click);
            // 
            // طرحToolStripMenuItem
            // 
            this.طرحToolStripMenuItem.Name = "طرحToolStripMenuItem";
            this.طرحToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.طرحToolStripMenuItem.Text = "multiply";
            this.طرحToolStripMenuItem.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // قسمهToolStripMenuItem
            // 
            this.قسمهToolStripMenuItem.Name = "قسمهToolStripMenuItem";
            this.قسمهToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.قسمهToolStripMenuItem.Text = "division";
            this.قسمهToolStripMenuItem.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(257, 209);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_substrat);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.toll_division);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toll_division;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_substrat;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ضربToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جمعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طرحToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قسمهToolStripMenuItem;
    }
}

