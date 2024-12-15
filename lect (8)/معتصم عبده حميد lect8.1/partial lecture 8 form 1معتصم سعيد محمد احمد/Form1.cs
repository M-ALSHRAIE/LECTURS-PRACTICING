using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partial_lecture_8_form_1_معتصم_عبده_حميد_يحيى
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_len_str_all_Click(object sender, EventArgs e)
        {
            if (txt_write_word.Text.Length > 0)
            {


                txt_len_str_all.Text = txt_write_word.Text.Length.ToString();
            }
            else
            {
                MessageBox.Show("يرجى ادخال   نص", "تنبيه");

            }
        }

        private void btn_len_str_selected_Click(object sender, EventArgs e)
        {
            if (txt_write_word.SelectedText.Length > 0)
            {
                txt_len_str_select.Text = txt_write_word.SelectionLength.ToString();
            }
            else
            {
                MessageBox.Show("يرجى تحديد  نص", "تنبيه");
            }
        }

        private void btn_count_word_all_Click(object sender, EventArgs e)
        {
            if (txt_write_word.Text.Length > 0)
            {
                string[] strword = txt_write_word.Text.Split(' ');
                int x = 0;
                for (int i = 0; i < strword.Length; i++)
                {
                    if (strword[i] != " ")
                    {
                        x++;
                    }
                }
                txt_count_word_all.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("يرجى ادخال نص ", "تنبيه");
            }
        }

        private void btn_count_word_selected_Click(object sender, EventArgs e)
        {
            if (txt_write_word.SelectionLength > 0)
            {
                string[] strwor = txt_write_word.SelectedText.Split(' ');
                int x = 0;
                foreach (string strword in strwor)
                {
                    if (strword != " ")
                    {
                        x++;
                    }
                }
                txt_count_word_select.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("يرجى تحديد  نص", "تنبيه");
            }
        }

        private void btn_clear_str_selected_Click(object sender, EventArgs e)
        {
            if(txt_write_word.SelectionLength>0)
            {
                txt_write_word.SelectedText= " ";
            }
            else
            {
                MessageBox.Show("يرجى تحديد  نص", "تنبيه");

            }
        }

        private void btn_deselect_Click(object sender, EventArgs e)
        {
            if(txt_write_word.SelectionLength>0)
            {
                txt_write_word.SelectionLength= 0;
            }
            else
            {
                MessageBox.Show("يرجى تحديد  نص", "تنبيه");
            }
        }
        string mystring = "";
        private void btn_copy_Click(object sender, EventArgs e)
        {
            if(txt_write_word.SelectionLength>0)
            {
                Clipboard.SetText(txt_write_word.SelectedText);
                mystring= txt_write_word.SelectedText;
            }
            else
            {
                MessageBox.Show("يرجى تحديد  نص", "تنبيه");

            }

        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            if(txt_write_word.SelectedText.Length>0)
            {
                mystring = txt_write_word.SelectedText;
                txt_write_word.SelectedText = "";
            }
            else
            {
                MessageBox.Show("يرجى تحديد  نص", "تنبيه");

            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if(txt_write_word.Text.Length>0)
            {
                txt_write_word.Clear();
            }
        }

        private void btn_len_str_all_notspac_Click(object sender, EventArgs e)
        {
            if(txt_write_word.Text.Length>0)
            {
                int x = 0;
                for (int i = 0;i<txt_write_word.Text.Length;i++)
                {
                    if (txt_write_word.Text[i]!=' ')
                    {
                        x++;

                    }
                }
                MessageBox.Show(x.ToString());
            }
            else
            {
                MessageBox.Show("يرجى كتابة  نص", "تنبيه");
            }
        }

        private void btn_len_sel_noyspace_Click(object sender, EventArgs e)
        {
            if (txt_write_word.SelectedText.Length > 0)
            {
                int y = 0;
                for (int i = 0; i < txt_write_word.SelectedText.Length; i++)
                {
                    if(txt_write_word.SelectedText[i]!=' ')
                    {
                        y++;
                    }
                }
                MessageBox.Show(y.ToString());
            }
            else
            {
                MessageBox.Show("يرجى تحديد  نص", "تنبيه");
            }
        }

        private void btn_past_Click(object sender, EventArgs e)
        {
            txt_paste_reteart.Text=mystring.Trim();
            //txt_paste_reteart.Paste();
        }

        private void btn_retreat_Click(object sender, EventArgs e)
        {
           // txt_write_word.Undo();
            txt_paste_reteart.Undo();
            
        }

        private void byn_group1_replace_Click(object sender, EventArgs e)
        {
            if(txt_write_word.SelectionLength>0)
            {
                if(txt_gruop1_replac.Text.Trim()!="")
                {
                    txt_write_word.SelectedText = txt_gruop1_replac.Text;
                }
                else
                {
                    MessageBox.Show("enterthe text now", "warning");
                }
            }
            else
            {
                MessageBox.Show("حدد النص المراد تعديله", "تنبيه");
            }
        }

        private void btn_search_group2_Click(object sender, EventArgs e)
        {
            if(txt_search_group2.Text.Trim()!="")
            {
                int index = txt_write_word.Text.IndexOf(txt_search_group2.Text, 0);
                if(index>-1)
                {
                    txt_write_word.SelectionStart = index;
                    txt_write_word.SelectionLength = txt_search_group2.Text.Length;
                    txt_write_word.Focus();
                }
                else
                {
                    MessageBox.Show("غير موجود", "تنبيه");
                    txt_search_group2.Text = " ";
                }
            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه");
                txt_search_group2.Focus();
            }
        }

        private void btn_search_next_Click(object sender, EventArgs e)
        {
            if(txt_search_group2.Text.Trim()!="")
            {
                int index = txt_write_word.Text.IndexOf(txt_search_group2.Text, txt_write_word.SelectionStart + txt_write_word.SelectionLength);
                if(index>-1)
                {
                    txt_write_word.Focus();
                    txt_write_word.Select(index, txt_search_group2.Text.Length);
                }
                else
                {
                    MessageBox.Show("غير موجود", "تنبيه");
                }
            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه");
                txt_search_group2.Focus();
            }
            
        }

        private void btn_seach_former_Click(object sender, EventArgs e)
        {
            if(txt_search_group2.Text.Trim()!="")
            {
                int index=txt_write_word.Text.LastIndexOf(txt_search_group2.Text,txt_write_word.SelectionStart+txt_write_word.SelectionLength);
                if(index>-1)
                {
                    txt_write_word.Focus();
                    txt_write_word.Select(index, txt_search_group2.Text.Length);
                }
                else
                {
                    MessageBox.Show("غير موجود", "تنبيه");
                }
            }
            else
            {
                MessageBox.Show("ادخل النص المراد البحث عنه");
                txt_search_group2.Focus();
            }
        }

        private void btn_show_word_selected_Click(object sender, EventArgs e)
        {
            listBox_char.Items.Clear();
            string s = txt_write_word.SelectedText;
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] != ' ')
                {
                    listBox_char.Items.Add(ch[i]);
                }
            }
        }

        private void btn_show_sentence_selected_Click(object sender, EventArgs e)
        {
            listbox_word.Items.Clear();
            string [] s=txt_write_word.SelectedText.Split(' ');
            for(int i = 0;i<s.Length;i++)
            {
                if(s[i] != " ")
                {
                    listbox_word.Items.Add(s[i]);
                }
            }
        }
    }
}
