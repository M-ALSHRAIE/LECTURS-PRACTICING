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
    public partial class Form1 : Form
    {
        public static string staticvariable = "";
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string name)
        {
            InitializeComponent();
            this.Text = name;
        }
        Form2 obfo11;
        public Form1(Form2 objectform11)
        {
            InitializeComponent();
            txt_add.Text = objectform11.getname();
           // txt_add=objectform11.tx
            obfo11 = objectform11;

        }
        public Form1(ListBox mylist)
        {
            InitializeComponent();
            list1= mylist;
        }
        public void  setvalue(string name)
        {
            txt_add.Text=name;

        }
        public string getvalu()
        {
            return txt_add.Text;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            list1.Items.Add(txt_add.Text);
            
        }

        private void btn_updat_Click(object sender, EventArgs e)
        {
           obfo11.updatename(getvalu());
            //obfo11.updatename(txt_add.Text);
           //Close();
        }

        private void txt_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
