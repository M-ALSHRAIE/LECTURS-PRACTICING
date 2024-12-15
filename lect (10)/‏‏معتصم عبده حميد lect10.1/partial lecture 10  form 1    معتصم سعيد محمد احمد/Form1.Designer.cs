namespace partial_lecture_10__form_1_حميد__معتصم_عبده
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lab_file_path = new System.Windows.Forms.Label();
            this.lab_extension = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_file_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.driveListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DriveListBox();
            this.dirListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.DirListBox();
            this.fileListBox1 = new Microsoft.VisualBasic.Compatibility.VB6.FileListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTextBox1.Location = new System.Drawing.Point(360, 93);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(162, 93);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lab_file_path
            // 
            this.lab_file_path.AutoSize = true;
            this.lab_file_path.Location = new System.Drawing.Point(87, 7);
            this.lab_file_path.Name = "lab_file_path";
            this.lab_file_path.Size = new System.Drawing.Size(27, 13);
            this.lab_file_path.TabIndex = 1;
            this.lab_file_path.Text = ".....";
            // 
            // lab_extension
            // 
            this.lab_extension.AutoSize = true;
            this.lab_extension.Location = new System.Drawing.Point(86, 69);
            this.lab_extension.Name = "lab_extension";
            this.lab_extension.Size = new System.Drawing.Size(31, 13);
            this.lab_extension.TabIndex = 2;
            this.lab_extension.Text = "......";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "الامتداد : ";
            // 
            // lab_file_name
            // 
            this.lab_file_name.AutoSize = true;
            this.lab_file_name.Location = new System.Drawing.Point(87, 39);
            this.lab_file_name.Name = "lab_file_name";
            this.lab_file_name.Size = new System.Drawing.Size(35, 13);
            this.lab_file_name.TabIndex = 4;
            this.lab_file_name.Text = ".......";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "اسم الملف : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = " مسار الملف : ";
            // 
            // driveListBox1
            // 
            this.driveListBox1.FormattingEnabled = true;
            this.driveListBox1.Location = new System.Drawing.Point(13, 103);
            this.driveListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.driveListBox1.Name = "driveListBox1";
            this.driveListBox1.Size = new System.Drawing.Size(213, 21);
            this.driveListBox1.TabIndex = 7;
            this.driveListBox1.SelectedIndexChanged += new System.EventHandler(this.driveListBox1_SelectedIndexChanged);
            // 
            // dirListBox1
            // 
            this.dirListBox1.FormattingEnabled = true;
            this.dirListBox1.IntegralHeight = false;
            this.dirListBox1.Location = new System.Drawing.Point(5, 139);
            this.dirListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dirListBox1.Name = "dirListBox1";
            this.dirListBox1.Size = new System.Drawing.Size(241, 175);
            this.dirListBox1.TabIndex = 8;
            this.dirListBox1.SelectedIndexChanged += new System.EventHandler(this.dirListBox1_SelectedIndexChanged);
            // 
            // fileListBox1
            // 
            this.fileListBox1.FormattingEnabled = true;
            this.fileListBox1.Location = new System.Drawing.Point(3, 342);
            this.fileListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileListBox1.Name = "fileListBox1";
            this.fileListBox1.Pattern = "*.*";
            this.fileListBox1.Size = new System.Drawing.Size(241, 173);
            this.fileListBox1.TabIndex = 9;
            this.fileListBox1.SelectedIndexChanged += new System.EventHandler(this.fileListBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 318);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 354);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(134, 318);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(112, 19);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "رجوع خطوه";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(406, 250);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(202, 165);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(586, 559);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fileListBox1);
            this.Controls.Add(this.dirListBox1);
            this.Controls.Add(this.driveListBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab_file_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_extension);
            this.Controls.Add(this.lab_file_path);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.FileListBox fileListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DirListBox dirListBox1;
        private Microsoft.VisualBasic.Compatibility.VB6.DriveListBox driveListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_file_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_extension;
        private System.Windows.Forms.Label lab_file_path;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_back;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

