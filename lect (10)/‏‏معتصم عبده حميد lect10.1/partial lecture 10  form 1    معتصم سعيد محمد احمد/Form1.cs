using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_10__form_1_حميد__معتصم_عبده
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox1.Path = driveListBox1.Drive; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("*.png");
            comboBox1.Items.Add("*.pneg");
            comboBox1.Items.Add("*.jpg");
            comboBox1.Items.Add("*.txt");
            comboBox1.Items.Add("*.mp4");
            comboBox1.SelectedIndex = 0;
            richTextBox1.Visible = false;
            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
           Height = fileListBox1.Top + 250;
               Width= fileListBox1.Width+ 80;
            
            dirListBox1.Path = @"C:\"; // تحديد المسار للقرص C
            fileListBox1.Path = @"C:\"; // تحديد المسار للقرص C
            pictureBox1.Top = richTextBox1.Top = axWindowsMediaPlayer1.Top = 60;//الارتفاع
            pictureBox1.Left= richTextBox1.Left = axWindowsMediaPlayer1.Left =260;//الازاحه من اليسار
            pictureBox1.Width = richTextBox1.Width = axWindowsMediaPlayer1.Width = 300;//العرض
            pictureBox1.Height = richTextBox1.Height = axWindowsMediaPlayer1.Height = 300;//الطول

        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           fileListBox1.Path = dirListBox1.Path;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           fileListBox1.Pattern=comboBox1.Text.Trim();
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab_file_path.Text = fileListBox1.Path + "\\" + fileListBox1.FileName;
            lab_file_name.Text = Path.GetFileName(lab_file_path.Text);
            lab_extension.Text = Path.GetExtension(lab_file_path.Text);

           
                if (lab_extension.Text.Trim().ToLower() == ".txt")
                {
                    Width = fileListBox1.Width + 350;
                    richTextBox1.Text = File.ReadAllText(lab_file_path.Text);
                    pictureBox1.Image = null;
                    richTextBox1.Visible = true;
                    pictureBox1.Visible = false;
                    axWindowsMediaPlayer1.Visible = false; 
                }
                else if (lab_extension.Text.Trim().ToLower() == ".png" || lab_extension.Text.Trim().ToLower() == ".pneg" || lab_extension.Text.Trim().ToLower() == ".jpg")
                {
                    Width = fileListBox1.Width + 350;
                    pictureBox1.Image = Image.FromFile(lab_file_path.Text);
                    richTextBox1.Text = " ";
                    pictureBox1.Visible = true;
                    richTextBox1.Visible = false;
                    axWindowsMediaPlayer1.Visible = false; // إخفاء مشغل الفيديو
                }
                else if (lab_extension.Text.Trim().ToLower() == ".mp4")
                {
                    Width = fileListBox1.Width + 350;
                    richTextBox1.Visible = false;
                    pictureBox1.Visible = false;
                    axWindowsMediaPlayer1.URL = lab_file_path.Text; // تعيين المسار لتشغيل الفيديو
                    axWindowsMediaPlayer1.Visible = true; // إظهار مشغل الفيديو
                }        
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                // الحصول على المسار الحالي من DirListBox
                string currentPath = dirListBox1.Path;

                // استخدام Directory.GetParent للحصول على المجلد الأب
                string parentPath = Directory.GetParent(currentPath)?.FullName;

                if (!string.IsNullOrEmpty(parentPath)) // إذا كان هناك مجلد أب
                {
                    dirListBox1.Path = parentPath; // تحديث DirListBox
                    fileListBox1.Path = parentPath; // تحديث FileListBox

                    // إيقاف الفيديو إذا كان يتم تشغيله
                    axWindowsMediaPlayer1.Ctlcontrols.stop(); // توقف عن تشغيل الفيديو
                    // إعادة تعيين الأبعاد إلى الوضع الافتراضي (Form_Load)
                    Width = fileListBox1.Width + 80;
                    Height = fileListBox1.Top + 250;
                    axWindowsMediaPlayer1.Visible=false;
                    
                    // إخفاء العناصر إذا لم يكن هناك ملف معين
                    richTextBox1.Visible = false;
                    pictureBox1.Visible = false;
                }
                else
                {
                    MessageBox.Show("انت موجود بالفعل في الدليل الجذر.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
