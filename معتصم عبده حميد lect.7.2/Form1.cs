﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace معتصم_عبده_حميد_lect._7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("enter items");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
