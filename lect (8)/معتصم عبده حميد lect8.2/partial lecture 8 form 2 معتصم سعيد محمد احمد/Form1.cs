using System;
using System.Windows.Forms;

namespace partial_lecture_8_form_2_معتصم_عبده_حميد_يحيى
{
    public partial class Form1 : Form
    {
        private string[] undoArray = new string[10]; // مصفوفة لتخزين آخر 10 كلمات ملصوقة
        private int currentIndex = -1;               // مؤشر للموقع الحالي في المصفوفة

        private string copiedText = "";              // تخزين النص المنسوخ

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                copiedText = textBox1.SelectedText;
            }
            else
            {
                MessageBox.Show("يرجى تحديد نص لنسخه");
            }
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            if (copiedText != "")
            {
                AddToUndoArray(copiedText); // إضافة النص الملصوق إلى سجل التراجع
                textBox2.Text += copiedText + "\r\n";
            }
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                copiedText = textBox1.SelectedText;
                AddToUndoArray(copiedText); // إضافة النص المقطوع إلى سجل التراجع
                textBox1.SelectedText = ""; // إزالة النص المحدد من textBox1
            }
            else
            {
                MessageBox.Show("يرجى تحديد نص لقصه");
            }
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (currentIndex !=0)
            {
                // استرجاع آخر نص ملصوق ونقله إلى textBox1
                textBox1.Text += undoArray[currentIndex] + "\r\n";
                // إزالة النص من textBox2
                textBox2.Text = textBox2.Text.Replace(undoArray[currentIndex] + "\r\n", "");
                // تقليل المؤشر للتراجع خطوة
                currentIndex--;
            }
            else
            {
                MessageBox.Show("لا يوجد خطوات للتراجع");
            }
        }

        private void AddToUndoArray(string text)
        {
            // إذا وصلت المصفوفة لأقصى حجم، نقوم بإزالة أقدم عنصر
            if (currentIndex < 9)
            {
                currentIndex++;
            }
            else
            {
                // نقل النصوص خطوة واحدة للأمام عند امتلاء المصفوفة
                for (int i = 0; i < 9; i++)
                {
                    undoArray[i] = undoArray[i + 1];
                }
                currentIndex = 9;
            }

            undoArray[currentIndex] = text; // إضافة النص الجديد إلى آخر خطوة
        }

        private void btn_clear_txt1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_clear_text2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
