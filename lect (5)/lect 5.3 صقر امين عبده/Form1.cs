using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lect_5._3_معتصم_عبده_حميد
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //for (int i=0; i<800; i++)
            //{
            //    button1.Left += 1;
            //}

            //for(int i=0; i<=this.Width-button1.Width;i++)
            //{
            //    button1.Left += 1;
            //}

            //for (int    I=0; I<=this.Width; I++)
            //{
            //    button1.Left += 10;
            //   Thread.Sleep(100);
            //    Application.DoEvents();
            //    if(button1.Left>this.Width-button1.Width)
            //    {
            //        break;
            //    }
            //}

            threadgo = new Thread(go);
            threadgo.Start();
        }

        Thread threadgo;
        void go()
        {
            for(int i=0; i<=this.Width; i++)
            {
       Invoke    ((Action)(() =>
                {
                    button1.Left += 10;
                }));
                if(button1.Left>this.Width - button1.Width-50)
                {
                    break;
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        private void Btn_down_Click(object sender, EventArgs e)
        {
            //for(int i   =0; i<400; i++)
            //{
            //    button1.Top += 1;
            //}

            //for (int i=0; i<= this.Height-button3.Height-70;i++)
            //{
            //    button3.Top += 10;
            //    System.Threading.Thread.Sleep(100);
            //    Application.DoEvents();
            //}

            for(int i=button3.Top; i<=this.Height-button3.Height-70; i++)
            {
                if (button3.Top > this.Height - button3.Height - 70)
            {
                    break;
            }
                button3.Top += 10;
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadgo != null)
                threadgo.Abort();
        }
    }
}
