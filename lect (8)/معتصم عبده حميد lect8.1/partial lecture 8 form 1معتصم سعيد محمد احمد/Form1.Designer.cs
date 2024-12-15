namespace partial_lecture_8_form_1_معتصم_عبده_حميد_يحيى
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_count_word_all = new System.Windows.Forms.TextBox();
            this.txt_len_str_select = new System.Windows.Forms.TextBox();
            this.txt_len_str_all = new System.Windows.Forms.TextBox();
            this.btn_len_str_all = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_clear_str_selected = new System.Windows.Forms.Button();
            this.btn_count_word_all = new System.Windows.Forms.Button();
            this.btn_len_str_selected = new System.Windows.Forms.Button();
            this.btn_count_word_selected = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_write_word = new System.Windows.Forms.TextBox();
            this.btn_deselect = new System.Windows.Forms.Button();
            this.btn_len_str_all_notspac = new System.Windows.Forms.Button();
            this.btn_len_sel_noyspace = new System.Windows.Forms.Button();
            this.txt_count_word_select = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_gruop1_replac = new System.Windows.Forms.TextBox();
            this.byn_group1_replace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_seach_former = new System.Windows.Forms.Button();
            this.btn_search_next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search_group2 = new System.Windows.Forms.Button();
            this.txt_search_group2 = new System.Windows.Forms.TextBox();
            this.btn_past = new System.Windows.Forms.Button();
            this.btn_retreat = new System.Windows.Forms.Button();
            this.btn_show_word_selected = new System.Windows.Forms.Button();
            this.btn_show_sentence_selected = new System.Windows.Forms.Button();
            this.txt_paste_reteart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_char = new System.Windows.Forms.ListBox();
            this.listbox_word = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_count_word_all
            // 
            this.txt_count_word_all.Location = new System.Drawing.Point(593, 148);
            this.txt_count_word_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_count_word_all.Name = "txt_count_word_all";
            this.txt_count_word_all.Size = new System.Drawing.Size(105, 20);
            this.txt_count_word_all.TabIndex = 1;
            // 
            // txt_len_str_select
            // 
            this.txt_len_str_select.Location = new System.Drawing.Point(705, 148);
            this.txt_len_str_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_len_str_select.Name = "txt_len_str_select";
            this.txt_len_str_select.Size = new System.Drawing.Size(115, 20);
            this.txt_len_str_select.TabIndex = 2;
            // 
            // txt_len_str_all
            // 
            this.txt_len_str_all.Location = new System.Drawing.Point(825, 148);
            this.txt_len_str_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_len_str_all.Name = "txt_len_str_all";
            this.txt_len_str_all.Size = new System.Drawing.Size(115, 20);
            this.txt_len_str_all.TabIndex = 3;
            // 
            // btn_len_str_all
            // 
            this.btn_len_str_all.BackColor = System.Drawing.Color.Gold;
            this.btn_len_str_all.Location = new System.Drawing.Point(825, 117);
            this.btn_len_str_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_len_str_all.Name = "btn_len_str_all";
            this.btn_len_str_all.Size = new System.Drawing.Size(114, 19);
            this.btn_len_str_all.TabIndex = 4;
            this.btn_len_str_all.Text = "طول النص كاملا";
            this.btn_len_str_all.UseVisualStyleBackColor = false;
            this.btn_len_str_all.Click += new System.EventHandler(this.btn_len_str_all_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.Gold;
            this.btn_copy.Location = new System.Drawing.Point(146, 117);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(64, 19);
            this.btn_copy.TabIndex = 5;
            this.btn_copy.Text = "نسخ";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_clear_str_selected
            // 
            this.btn_clear_str_selected.BackColor = System.Drawing.Color.Gold;
            this.btn_clear_str_selected.Location = new System.Drawing.Point(315, 117);
            this.btn_clear_str_selected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_str_selected.Name = "btn_clear_str_selected";
            this.btn_clear_str_selected.Size = new System.Drawing.Size(130, 19);
            this.btn_clear_str_selected.TabIndex = 7;
            this.btn_clear_str_selected.Text = "حذف النص المحدد";
            this.btn_clear_str_selected.UseVisualStyleBackColor = false;
            this.btn_clear_str_selected.Click += new System.EventHandler(this.btn_clear_str_selected_Click);
            // 
            // btn_count_word_all
            // 
            this.btn_count_word_all.BackColor = System.Drawing.Color.Gold;
            this.btn_count_word_all.Location = new System.Drawing.Point(593, 117);
            this.btn_count_word_all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_count_word_all.Name = "btn_count_word_all";
            this.btn_count_word_all.Size = new System.Drawing.Size(105, 19);
            this.btn_count_word_all.TabIndex = 8;
            this.btn_count_word_all.Text = "عدد الكلمات كامل";
            this.btn_count_word_all.UseVisualStyleBackColor = false;
            this.btn_count_word_all.Click += new System.EventHandler(this.btn_count_word_all_Click);
            // 
            // btn_len_str_selected
            // 
            this.btn_len_str_selected.BackColor = System.Drawing.Color.Gold;
            this.btn_len_str_selected.Location = new System.Drawing.Point(705, 117);
            this.btn_len_str_selected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_len_str_selected.Name = "btn_len_str_selected";
            this.btn_len_str_selected.Size = new System.Drawing.Size(114, 19);
            this.btn_len_str_selected.TabIndex = 9;
            this.btn_len_str_selected.Text = "طول النص المحدد";
            this.btn_len_str_selected.UseVisualStyleBackColor = false;
            this.btn_len_str_selected.Click += new System.EventHandler(this.btn_len_str_selected_Click);
            // 
            // btn_count_word_selected
            // 
            this.btn_count_word_selected.BackColor = System.Drawing.Color.Gold;
            this.btn_count_word_selected.Location = new System.Drawing.Point(451, 117);
            this.btn_count_word_selected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_count_word_selected.Name = "btn_count_word_selected";
            this.btn_count_word_selected.Size = new System.Drawing.Size(137, 19);
            this.btn_count_word_selected.TabIndex = 10;
            this.btn_count_word_selected.Text = "عدد الكلمات المحدده";
            this.btn_count_word_selected.UseVisualStyleBackColor = false;
            this.btn_count_word_selected.Click += new System.EventHandler(this.btn_count_word_selected_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.BackColor = System.Drawing.Color.Gold;
            this.btn_cut.Location = new System.Drawing.Point(76, 117);
            this.btn_cut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(64, 19);
            this.btn_cut.TabIndex = 11;
            this.btn_cut.Text = "قص";
            this.btn_cut.UseVisualStyleBackColor = false;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Gold;
            this.btn_clear.Location = new System.Drawing.Point(7, 117);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(64, 19);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "تنظيف";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_write_word
            // 
            this.txt_write_word.Location = new System.Drawing.Point(7, 10);
            this.txt_write_word.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_write_word.Multiline = true;
            this.txt_write_word.Name = "txt_write_word";
            this.txt_write_word.Size = new System.Drawing.Size(932, 82);
            this.txt_write_word.TabIndex = 0;
            // 
            // btn_deselect
            // 
            this.btn_deselect.BackColor = System.Drawing.Color.Gold;
            this.btn_deselect.Location = new System.Drawing.Point(215, 117);
            this.btn_deselect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deselect.Name = "btn_deselect";
            this.btn_deselect.Size = new System.Drawing.Size(95, 19);
            this.btn_deselect.TabIndex = 6;
            this.btn_deselect.Text = "الغاء التحديد";
            this.btn_deselect.UseVisualStyleBackColor = false;
            this.btn_deselect.Click += new System.EventHandler(this.btn_deselect_Click);
            // 
            // btn_len_str_all_notspac
            // 
            this.btn_len_str_all_notspac.BackColor = System.Drawing.Color.Gold;
            this.btn_len_str_all_notspac.Location = new System.Drawing.Point(209, 150);
            this.btn_len_str_all_notspac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_len_str_all_notspac.Name = "btn_len_str_all_notspac";
            this.btn_len_str_all_notspac.Size = new System.Drawing.Size(213, 19);
            this.btn_len_str_all_notspac.TabIndex = 13;
            this.btn_len_str_all_notspac.Text = "طول النص كامل بدون فراغات";
            this.btn_len_str_all_notspac.UseVisualStyleBackColor = false;
            this.btn_len_str_all_notspac.Click += new System.EventHandler(this.btn_len_str_all_notspac_Click);
            // 
            // btn_len_sel_noyspace
            // 
            this.btn_len_sel_noyspace.BackColor = System.Drawing.Color.Gold;
            this.btn_len_sel_noyspace.Location = new System.Drawing.Point(7, 148);
            this.btn_len_sel_noyspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_len_sel_noyspace.Name = "btn_len_sel_noyspace";
            this.btn_len_sel_noyspace.Size = new System.Drawing.Size(196, 19);
            this.btn_len_sel_noyspace.TabIndex = 14;
            this.btn_len_sel_noyspace.Text = "طول النص المحدد بدون فراغات";
            this.btn_len_sel_noyspace.UseVisualStyleBackColor = false;
            this.btn_len_sel_noyspace.Click += new System.EventHandler(this.btn_len_sel_noyspace_Click);
            // 
            // txt_count_word_select
            // 
            this.txt_count_word_select.Location = new System.Drawing.Point(451, 149);
            this.txt_count_word_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_count_word_select.Name = "txt_count_word_select";
            this.txt_count_word_select.Size = new System.Drawing.Size(138, 20);
            this.txt_count_word_select.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_gruop1_replac);
            this.groupBox1.Controls.Add(this.byn_group1_replace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(642, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(297, 131);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "استبدال";
            // 
            // txt_gruop1_replac
            // 
            this.txt_gruop1_replac.Location = new System.Drawing.Point(58, 46);
            this.txt_gruop1_replac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_gruop1_replac.Name = "txt_gruop1_replac";
            this.txt_gruop1_replac.Size = new System.Drawing.Size(109, 20);
            this.txt_gruop1_replac.TabIndex = 18;
            // 
            // byn_group1_replace
            // 
            this.byn_group1_replace.Location = new System.Drawing.Point(78, 85);
            this.byn_group1_replace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.byn_group1_replace.Name = "byn_group1_replace";
            this.byn_group1_replace.Size = new System.Drawing.Size(64, 19);
            this.byn_group1_replace.TabIndex = 1;
            this.byn_group1_replace.Text = "استبدال";
            this.byn_group1_replace.UseVisualStyleBackColor = true;
            this.byn_group1_replace.Click += new System.EventHandler(this.byn_group1_replace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "النص الجديد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_seach_former);
            this.groupBox2.Controls.Add(this.btn_search_next);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_search_group2);
            this.groupBox2.Controls.Add(this.txt_search_group2);
            this.groupBox2.Location = new System.Drawing.Point(136, 192);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(393, 131);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بحث";
            this.groupBox2.UseWaitCursor = true;
            // 
            // btn_seach_former
            // 
            this.btn_seach_former.Location = new System.Drawing.Point(143, 96);
            this.btn_seach_former.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seach_former.Name = "btn_seach_former";
            this.btn_seach_former.Size = new System.Drawing.Size(108, 19);
            this.btn_seach_former.TabIndex = 4;
            this.btn_seach_former.Text = "بحث عن السابق";
            this.btn_seach_former.UseVisualStyleBackColor = true;
            this.btn_seach_former.UseWaitCursor = true;
            this.btn_seach_former.Click += new System.EventHandler(this.btn_seach_former_Click);
            // 
            // btn_search_next
            // 
            this.btn_search_next.Location = new System.Drawing.Point(22, 96);
            this.btn_search_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_next.Name = "btn_search_next";
            this.btn_search_next.Size = new System.Drawing.Size(107, 19);
            this.btn_search_next.TabIndex = 3;
            this.btn_search_next.Text = "بحث عن التالي";
            this.btn_search_next.UseVisualStyleBackColor = true;
            this.btn_search_next.UseWaitCursor = true;
            this.btn_search_next.Click += new System.EventHandler(this.btn_search_next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "النص المراد البحث عنه";
            this.label2.UseWaitCursor = true;
            // 
            // btn_search_group2
            // 
            this.btn_search_group2.Location = new System.Drawing.Point(302, 96);
            this.btn_search_group2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_group2.Name = "btn_search_group2";
            this.btn_search_group2.Size = new System.Drawing.Size(64, 19);
            this.btn_search_group2.TabIndex = 1;
            this.btn_search_group2.Text = "بحث";
            this.btn_search_group2.UseVisualStyleBackColor = true;
            this.btn_search_group2.UseWaitCursor = true;
            this.btn_search_group2.Click += new System.EventHandler(this.btn_search_group2_Click);
            // 
            // txt_search_group2
            // 
            this.txt_search_group2.Location = new System.Drawing.Point(143, 46);
            this.txt_search_group2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search_group2.Name = "txt_search_group2";
            this.txt_search_group2.Size = new System.Drawing.Size(164, 20);
            this.txt_search_group2.TabIndex = 0;
            this.txt_search_group2.UseWaitCursor = true;
            // 
            // btn_past
            // 
            this.btn_past.BackColor = System.Drawing.Color.Gold;
            this.btn_past.Location = new System.Drawing.Point(859, 370);
            this.btn_past.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_past.Name = "btn_past";
            this.btn_past.Size = new System.Drawing.Size(80, 30);
            this.btn_past.TabIndex = 18;
            this.btn_past.Text = "لصق";
            this.btn_past.UseVisualStyleBackColor = false;
            this.btn_past.Click += new System.EventHandler(this.btn_past_Click);
            // 
            // btn_retreat
            // 
            this.btn_retreat.BackColor = System.Drawing.Color.Gold;
            this.btn_retreat.Location = new System.Drawing.Point(700, 370);
            this.btn_retreat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_retreat.Name = "btn_retreat";
            this.btn_retreat.Size = new System.Drawing.Size(85, 30);
            this.btn_retreat.TabIndex = 19;
            this.btn_retreat.Text = "تراجع";
            this.btn_retreat.UseVisualStyleBackColor = false;
            this.btn_retreat.Click += new System.EventHandler(this.btn_retreat_Click);
            // 
            // btn_show_word_selected
            // 
            this.btn_show_word_selected.BackColor = System.Drawing.Color.Gold;
            this.btn_show_word_selected.Location = new System.Drawing.Point(450, 370);
            this.btn_show_word_selected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show_word_selected.Name = "btn_show_word_selected";
            this.btn_show_word_selected.Size = new System.Drawing.Size(138, 32);
            this.btn_show_word_selected.TabIndex = 20;
            this.btn_show_word_selected.Text = "عرض";
            this.btn_show_word_selected.UseVisualStyleBackColor = false;
            this.btn_show_word_selected.Click += new System.EventHandler(this.btn_show_word_selected_Click);
            // 
            // btn_show_sentence_selected
            // 
            this.btn_show_sentence_selected.BackColor = System.Drawing.Color.Gold;
            this.btn_show_sentence_selected.Location = new System.Drawing.Point(176, 370);
            this.btn_show_sentence_selected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show_sentence_selected.Name = "btn_show_sentence_selected";
            this.btn_show_sentence_selected.Size = new System.Drawing.Size(135, 32);
            this.btn_show_sentence_selected.TabIndex = 21;
            this.btn_show_sentence_selected.Text = "عرض";
            this.btn_show_sentence_selected.UseVisualStyleBackColor = false;
            this.btn_show_sentence_selected.Click += new System.EventHandler(this.btn_show_sentence_selected_Click);
            // 
            // txt_paste_reteart
            // 
            this.txt_paste_reteart.Location = new System.Drawing.Point(700, 406);
            this.txt_paste_reteart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_paste_reteart.Multiline = true;
            this.txt_paste_reteart.Name = "txt_paste_reteart";
            this.txt_paste_reteart.Size = new System.Drawing.Size(239, 127);
            this.txt_paste_reteart.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "احرف الكلمه المحدده";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "كلمات الجمله المحدده";
            // 
            // listBox_char
            // 
            this.listBox_char.FormattingEnabled = true;
            this.listBox_char.Location = new System.Drawing.Point(410, 406);
            this.listBox_char.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_char.Name = "listBox_char";
            this.listBox_char.Size = new System.Drawing.Size(236, 108);
            this.listBox_char.TabIndex = 28;
            // 
            // listbox_word
            // 
            this.listbox_word.FormattingEnabled = true;
            this.listbox_word.Location = new System.Drawing.Point(159, 406);
            this.listbox_word.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbox_word.Name = "listbox_word";
            this.listbox_word.Size = new System.Drawing.Size(229, 108);
            this.listbox_word.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(957, 529);
            this.Controls.Add(this.listbox_word);
            this.Controls.Add(this.listBox_char);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_paste_reteart);
            this.Controls.Add(this.btn_show_sentence_selected);
            this.Controls.Add(this.btn_show_word_selected);
            this.Controls.Add(this.btn_retreat);
            this.Controls.Add(this.btn_past);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_count_word_select);
            this.Controls.Add(this.btn_len_sel_noyspace);
            this.Controls.Add(this.btn_len_str_all_notspac);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.btn_count_word_selected);
            this.Controls.Add(this.btn_len_str_selected);
            this.Controls.Add(this.btn_count_word_all);
            this.Controls.Add(this.btn_clear_str_selected);
            this.Controls.Add(this.btn_deselect);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_len_str_all);
            this.Controls.Add(this.txt_len_str_all);
            this.Controls.Add(this.txt_len_str_select);
            this.Controls.Add(this.txt_count_word_all);
            this.Controls.Add(this.txt_write_word);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_count_word_all;
        private System.Windows.Forms.TextBox txt_len_str_select;
        private System.Windows.Forms.TextBox txt_len_str_all;
        private System.Windows.Forms.Button btn_len_str_all;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_clear_str_selected;
        private System.Windows.Forms.Button btn_count_word_all;
        private System.Windows.Forms.Button btn_len_str_selected;
        private System.Windows.Forms.Button btn_count_word_selected;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_write_word;
        private System.Windows.Forms.Button btn_deselect;
        private System.Windows.Forms.Button btn_len_str_all_notspac;
        private System.Windows.Forms.Button btn_len_sel_noyspace;
        private System.Windows.Forms.TextBox txt_count_word_select;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_gruop1_replac;
        private System.Windows.Forms.Button byn_group1_replace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_seach_former;
        private System.Windows.Forms.Button btn_search_next;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search_group2;
        private System.Windows.Forms.TextBox txt_search_group2;
        private System.Windows.Forms.Button btn_past;
        private System.Windows.Forms.Button btn_retreat;
        private System.Windows.Forms.Button btn_show_word_selected;
        private System.Windows.Forms.Button btn_show_sentence_selected;
        private System.Windows.Forms.TextBox txt_paste_reteart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_char;
        private System.Windows.Forms.ListBox listbox_word;
    }
}

