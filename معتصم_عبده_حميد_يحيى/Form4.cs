using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace معتصم_عبده_حميد_الشراعي
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            for(int i=0; i<Form2.count;i++)
            {
                listBox1.Items.Add(Form2.d[i].getnumber().ToString());
                listBox1.SelectedIndex = 0;
            }
        }

        public static int index = -1;
        private void Form4_Load(object sender, EventArgs e)
        {
            loaddata();
        }
         void findselectedindex(object sender, EventArgs e)
        {
            if(((ListBox)sender).SelectedIndex !=-1)
            {
                index = listBox1.SelectedIndex = ((ListBox)sender).SelectedIndex;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            int s = 0;
            foreach(var item in listBox1.Items)
            {
                if(int.TryParse(item.ToString(),out int number))
                {
                  s += number;
                    textBox1.Text = s.ToString();
                }

            }
        }
    }
}
