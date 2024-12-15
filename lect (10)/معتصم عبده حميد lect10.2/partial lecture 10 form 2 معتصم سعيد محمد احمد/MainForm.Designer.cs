namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.steudent_data_manegment = new System.Windows.Forms.ToolStripMenuItem();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.addASteudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steudentShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steudent_data_manegment,
            this.file,
            this.close});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
        //    this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // steudent_data_manegment
            // 
            this.steudent_data_manegment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addASteudentToolStripMenuItem,
            this.steudentShowToolStripMenuItem});
            this.steudent_data_manegment.Name = "steudent_data_manegment";
            this.steudent_data_manegment.Size = new System.Drawing.Size(190, 24);
            this.steudent_data_manegment.Text = "data steudent mangment";
            //this.steudent_data_manegment.Click += new System.EventHandler(this.sssToolStripMenuItem_Click);
            // 
            // file
            // 
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(44, 24);
            this.file.Text = "file";
            // 
            // close
            // 
            this.close.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(57, 24);
            this.close.Text = "close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // addASteudentToolStripMenuItem
            // 
            this.addASteudentToolStripMenuItem.Name = "addASteudentToolStripMenuItem";
            this.addASteudentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addASteudentToolStripMenuItem.Text = "add a steudent ";
            this.addASteudentToolStripMenuItem.Click += new System.EventHandler(this.addASteudentToolStripMenuItem_Click);
            // 
            // steudentShowToolStripMenuItem
            // 
            this.steudentShowToolStripMenuItem.Name = "steudentShowToolStripMenuItem";
            this.steudentShowToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.steudentShowToolStripMenuItem.Text = "steudent show";
            this.steudentShowToolStripMenuItem.Click += new System.EventHandler(this.steudentShowToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeAllToolStripMenuItem.Text = "close all";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem steudent_data_manegment;
        private System.Windows.Forms.ToolStripMenuItem addASteudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steudentShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
    }
}