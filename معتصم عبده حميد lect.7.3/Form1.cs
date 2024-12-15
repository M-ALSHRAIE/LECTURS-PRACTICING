using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_7_form_3_معتصم_عبده_حميد_يحيى
{
    public partial class Form1 : Form
    {
       // add a;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
      add ad;
        private void btn_addition_Click(object sender, EventArgs e)
        {
            if (ad == null || ad.IsDisposed)
            {
                ad=new add();
                ad.Show();
            }
            else
            {
                ad.Show();
            }
           
        }

        sub su;
        private void btn_substrat_Click(object sender, EventArgs e)
        {
            if(su==null || su.IsDisposed)
            {
                su=new sub();
                su.Show();

            }
            else
            {
                su.Show();
            }

        }
        mult mu;
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if(mu==null || mu.IsDisposed)
            {
                mu=new mult();
                mu.Show();

            }
            else
            {
                mu.Show();
            }
        }
        div di;
        private void btn_division_Click(object sender, EventArgs e)
        {
            if(di==null || di.IsDisposed)
            {
                di=new div();
                di.Show();

            }
            else
            {
                di.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
