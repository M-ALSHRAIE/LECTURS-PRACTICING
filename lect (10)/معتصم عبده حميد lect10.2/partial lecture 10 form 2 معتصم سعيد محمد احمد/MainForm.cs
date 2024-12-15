using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sssToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        Form2 f2;
        private void addASteudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Form2();
                f2.Show();
            }
            else
            {
                f2.Focus();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        Form3 f3;
        private void steudentShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(f3 == null || f3.IsDisposed)
            {
                f3=new Form3();
                f3.Show();

            }
            else
            {
                f3.Focus();
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if(count > 1)
            {
                Application.OpenForms[count - 1].Close();
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count=Application.OpenForms.Count;
            if(count>1)
            {
                for (int i=0;i<count-1;i++)
                {
                   
                    Application.OpenForms[i].Close();
                }
            }
        }
    }
}
