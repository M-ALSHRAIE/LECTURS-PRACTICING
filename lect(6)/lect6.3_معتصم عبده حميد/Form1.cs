using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect6._3_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog openfiledialog1;
        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           
            openfiledialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            if(openfiledialog1.ShowDialog()==DialogResult.OK)
            { 
         //       pictureBox1.Image = Image.FromFile(openfiledialog1.FileName);
                string filrname = openfiledialog1.FileName;
                Bitmap mybitmap = new Bitmap(filrname);
                pictureBox1.Image = mybitmap;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
