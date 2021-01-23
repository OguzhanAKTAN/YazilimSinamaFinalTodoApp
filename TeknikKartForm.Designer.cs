namespace YazilimSinamaFinal
{
    partial class TeknikKartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_takip = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yapilacakis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_cardname = new System.Windows.Forms.TextBox();
            this.label_cardname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_cardpersonel = new System.Windows.Forms.ListBox();
            this.button_removepersonel = new System.Windows.Forms.Button();
            this.button_addpersonel = new System.Windows.Forms.Button();
            this.label_cardno = new System.Windows.Forms.Label();
            this.label_calculate = new System.Windows.Forms.Label();
            this.listBox_projectpersonel = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_add_card = new System.Windows.Forms.Button();
            this.button_update_card = new System.Windows.Forms.Button();
            this.button_delete_card = new System.Windows.Forms.Button();
            this.label_card_date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_takip)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_takip
            // 
            this.dataGridView_takip.AllowUserToAddRows = false;
            this.dataGridView_takip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_takip.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.dataGridView_takip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_takip.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_takip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_takip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_takip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.Durum,
            this.Yapilacakis,
            this.Aciklama});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_takip.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_takip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.dataGridView_takip.Location = new System.Drawing.Point(11, 415);
            this.dataGridView_takip.Name = "dataGridView_takip";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_takip.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.dataGridView_takip.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_takip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_takip.Size = new System.Drawing.Size(1063, 214);
            this.dataGridView_takip.TabIndex = 1;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Durum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Yapilacakis
            // 
            this.Yapilacakis.HeaderText = "Yapilacak İş";
            this.Yapilacakis.Name = "Yapilacakis";
            this.Yapilacakis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Yapilacakis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            // 
            // textBox_notes
            // 
            this.textBox_notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.textBox_notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_notes.ForeColor = System.Drawing.Color.White;
            this.textBox_notes.Location = new System.Drawing.Point(11, 298);
            this.textBox_notes.Multiline = true;
            this.textBox_notes.Name = "textBox_notes";
            this.textBox_notes.Size = new System.Drawing.Size(1062, 86);
            this.textBox_notes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(11, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notlar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(11, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "İş Takibi";
            // 
            // textBox_desc
            // 
            this.textBox_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.textBox_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desc.ForeColor = System.Drawing.Color.White;
            this.textBox_desc.Location = new System.Drawing.Point(11, 140);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(1062, 128);
            this.textBox_desc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "İşin Açıklaması :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kart adı           :";
            // 
            // textBox_cardname
            // 
            this.textBox_cardname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.textBox_cardname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_cardname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cardname.ForeColor = System.Drawing.Color.White;
            this.textBox_cardname.Location = new System.Drawing.Point(126, 70);
            this.textBox_cardname.Name = "textBox_cardname";
            this.textBox_cardname.Size = new System.Drawing.Size(260, 19);
            this.textBox_cardname.TabIndex = 8;
            // 
            // label_cardname
            // 
            this.label_cardname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.label_cardname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cardname.ForeColor = System.Drawing.Color.White;
            this.label_cardname.Location = new System.Drawing.Point(12, 9);
            this.label_cardname.Name = "label_cardname";
            this.label_cardname.Size = new System.Drawing.Size(374, 43);
            this.label_cardname.TabIndex = 11;
            this.label_cardname.Text = "TEKNIK KART";
            this.label_cardname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(763, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tarih              :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 389);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(761, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kart No          :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(761, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tahmini Süre";
            // 
            // listBox_cardpersonel
            // 
            this.listBox_cardpersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.listBox_cardpersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_cardpersonel.ForeColor = System.Drawing.Color.White;
            this.listBox_cardpersonel.FormattingEnabled = true;
            this.listBox_cardpersonel.Location = new System.Drawing.Point(539, 22);
            this.listBox_cardpersonel.Name = "listBox_cardpersonel";
            this.listBox_cardpersonel.Size = new System.Drawing.Size(112, 106);
            this.listBox_cardpersonel.TabIndex = 17;
            // 
            // button_removepersonel
            // 
            this.button_removepersonel.FlatAppearance.BorderSize = 0;
            this.button_removepersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removepersonel.Image = global::YazilimSinamaFinal.Properties.Resources.icons8_delete_50;
            this.button_removepersonel.Location = new System.Drawing.Point(677, 70);
            this.button_removepersonel.Name = "button_removepersonel";
            this.button_removepersonel.Size = new System.Drawing.Size(63, 64);
            this.button_removepersonel.TabIndex = 19;
            this.button_removepersonel.UseVisualStyleBackColor = true;
            this.button_removepersonel.Click += new System.EventHandler(this.button_removepersonel_Click);
            // 
            // button_addpersonel
            // 
            this.button_addpersonel.FlatAppearance.BorderSize = 0;
            this.button_addpersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addpersonel.Image = global::YazilimSinamaFinal.Properties.Resources.icons8_plus_64;
            this.button_addpersonel.Location = new System.Drawing.Point(677, 9);
            this.button_addpersonel.Name = "button_addpersonel";
            this.button_addpersonel.Size = new System.Drawing.Size(63, 60);
            this.button_addpersonel.TabIndex = 18;
            this.button_addpersonel.UseVisualStyleBackColor = true;
            this.button_addpersonel.Click += new System.EventHandler(this.button_addpersonel_Click);
            // 
            // label_cardno
            // 
            this.label_cardno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cardno.ForeColor = System.Drawing.Color.White;
            this.label_cardno.Location = new System.Drawing.Point(868, 35);
            this.label_cardno.Name = "label_cardno";
            this.label_cardno.Size = new System.Drawing.Size(49, 22);
            this.label_cardno.TabIndex = 20;
            // 
            // label_calculate
            // 
            this.label_calculate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calculate.ForeColor = System.Drawing.Color.White;
            this.label_calculate.Location = new System.Drawing.Point(864, 89);
            this.label_calculate.Name = "label_calculate";
            this.label_calculate.Size = new System.Drawing.Size(204, 22);
            this.label_calculate.TabIndex = 21;
            // 
            // listBox_projectpersonel
            // 
            this.listBox_projectpersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.listBox_projectpersonel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_projectpersonel.ForeColor = System.Drawing.Color.White;
            this.listBox_projectpersonel.FormattingEnabled = true;
            this.listBox_projectpersonel.Location = new System.Drawing.Point(397, 22);
            this.listBox_projectpersonel.Name = "listBox_projectpersonel";
            this.listBox_projectpersonel.Size = new System.Drawing.Size(112, 106);
            this.listBox_projectpersonel.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(394, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Teknik Uzmanlar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.label9.Location = new System.Drawing.Point(523, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Bu görevde çalışanlar";
            // 
            // button_add_card
            // 
            this.button_add_card.BackColor = System.Drawing.Color.SeaGreen;
            this.button_add_card.FlatAppearance.BorderSize = 0;
            this.button_add_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_card.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.button_add_card.Location = new System.Drawing.Point(724, 643);
            this.button_add_card.Name = "button_add_card";
            this.button_add_card.Size = new System.Drawing.Size(349, 75);
            this.button_add_card.TabIndex = 25;
            this.button_add_card.Text = "EKLE";
            this.button_add_card.UseVisualStyleBackColor = false;
            this.button_add_card.Click += new System.EventHandler(this.button_add_card_Click);
            // 
            // button_update_card
            // 
            this.button_update_card.BackColor = System.Drawing.Color.Goldenrod;
            this.button_update_card.FlatAppearance.BorderSize = 0;
            this.button_update_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update_card.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.button_update_card.Location = new System.Drawing.Point(374, 643);
            this.button_update_card.Name = "button_update_card";
            this.button_update_card.Size = new System.Drawing.Size(344, 75);
            this.button_update_card.TabIndex = 26;
            this.button_update_card.Text = "GUNCELLE";
            this.button_update_card.UseVisualStyleBackColor = false;
            this.button_update_card.Click += new System.EventHandler(this.button_update_card_Click);
            // 
            // button_delete_card
            // 
            this.button_delete_card.BackColor = System.Drawing.Color.Tomato;
            this.button_delete_card.FlatAppearance.BorderSize = 0;
            this.button_delete_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_card.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.button_delete_card.Location = new System.Drawing.Point(11, 643);
            this.button_delete_card.Name = "button_delete_card";
            this.button_delete_card.Size = new System.Drawing.Size(357, 75);
            this.button_delete_card.TabIndex = 27;
            this.button_delete_card.Text = "SIL";
            this.button_delete_card.UseVisualStyleBackColor = false;
            // 
            // label_card_date
            // 
            this.label_card_date.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_card_date.ForeColor = System.Drawing.Color.White;
            this.label_card_date.Location = new System.Drawing.Point(868, 5);
            this.label_card_date.Name = "label_card_date";
            this.label_card_date.Size = new System.Drawing.Size(204, 22);
            this.label_card_date.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeknikKartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1087, 732);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_card_date);
            this.Controls.Add(this.button_delete_card);
            this.Controls.Add(this.button_update_card);
            this.Controls.Add(this.button_add_card);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_projectpersonel);
            this.Controls.Add(this.label_calculate);
            this.Controls.Add(this.label_cardno);
            this.Controls.Add(this.button_removepersonel);
            this.Controls.Add(this.button_addpersonel);
            this.Controls.Add(this.listBox_cardpersonel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_cardname);
            this.Controls.Add(this.textBox_cardname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_notes);
            this.Controls.Add(this.dataGridView_takip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TeknikKartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TeknikKartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_takip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_takip;
        private System.Windows.Forms.TextBox textBox_notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_cardname;
        private System.Windows.Forms.Label label_cardname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox_cardpersonel;
        private System.Windows.Forms.Button button_addpersonel;
        private System.Windows.Forms.Button button_removepersonel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yapilacakis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.Label label_cardno;
        private System.Windows.Forms.Label label_calculate;
        private System.Windows.Forms.ListBox listBox_projectpersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_add_card;
        private System.Windows.Forms.Button button_update_card;
        private System.Windows.Forms.Button button_delete_card;
        private System.Windows.Forms.Label label_card_date;
        private System.Windows.Forms.Button button1;
    }
}