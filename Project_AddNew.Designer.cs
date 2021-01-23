namespace YazilimSinamaFinal
{
    partial class Project_AddNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_top = new System.Windows.Forms.Panel();
            this.textBox_prjname = new System.Windows.Forms.TextBox();
            this.label_projects = new System.Windows.Forms.Label();
            this.panel_middle = new System.Windows.Forms.Panel();
            this.dataGridView_personel = new System.Windows.Forms.DataGridView();
            this.Personel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personel_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.button_addProject = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.panel_middle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_personel)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.textBox_prjname);
            this.panel_top.Controls.Add(this.label_projects);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 66);
            this.panel_top.TabIndex = 0;
            // 
            // textBox_prjname
            // 
            this.textBox_prjname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(82)))));
            this.textBox_prjname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_prjname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_prjname.ForeColor = System.Drawing.Color.White;
            this.textBox_prjname.Location = new System.Drawing.Point(0, 45);
            this.textBox_prjname.Name = "textBox_prjname";
            this.textBox_prjname.Size = new System.Drawing.Size(800, 20);
            this.textBox_prjname.TabIndex = 2;
            // 
            // label_projects
            // 
            this.label_projects.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_projects.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_projects.ForeColor = System.Drawing.Color.White;
            this.label_projects.Location = new System.Drawing.Point(0, 0);
            this.label_projects.Name = "label_projects";
            this.label_projects.Size = new System.Drawing.Size(800, 45);
            this.label_projects.TabIndex = 1;
            this.label_projects.Text = "PROJE ADI";
            this.label_projects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_middle
            // 
            this.panel_middle.AutoScroll = true;
            this.panel_middle.Controls.Add(this.dataGridView_personel);
            this.panel_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_middle.Location = new System.Drawing.Point(0, 66);
            this.panel_middle.Name = "panel_middle";
            this.panel_middle.Size = new System.Drawing.Size(800, 384);
            this.panel_middle.TabIndex = 1;
            // 
            // dataGridView_personel
            // 
            this.dataGridView_personel.AllowUserToAddRows = false;
            this.dataGridView_personel.AllowUserToDeleteRows = false;
            this.dataGridView_personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_personel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.dataGridView_personel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_personel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_personel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_personel.ColumnHeadersVisible = false;
            this.dataGridView_personel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personel_id,
            this.Personel_name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_personel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_personel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_personel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.dataGridView_personel.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_personel.Name = "dataGridView_personel";
            this.dataGridView_personel.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_personel.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.dataGridView_personel.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_personel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView_personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_personel.Size = new System.Drawing.Size(800, 384);
            this.dataGridView_personel.TabIndex = 0;
            // 
            // Personel_id
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.Personel_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Personel_id.HeaderText = "Personel id";
            this.Personel_id.Name = "Personel_id";
            this.Personel_id.ReadOnly = true;
            // 
            // Personel_name
            // 
            this.Personel_name.HeaderText = "Personel İsim";
            this.Personel_name.Name = "Personel_name";
            this.Personel_name.ReadOnly = true;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.button_addProject);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 375);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(800, 75);
            this.panel_bottom.TabIndex = 2;
            // 
            // button_addProject
            // 
            this.button_addProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.button_addProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addProject.FlatAppearance.BorderSize = 0;
            this.button_addProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addProject.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.button_addProject.ForeColor = System.Drawing.Color.White;
            this.button_addProject.Location = new System.Drawing.Point(0, 0);
            this.button_addProject.Name = "button_addProject";
            this.button_addProject.Size = new System.Drawing.Size(800, 75);
            this.button_addProject.TabIndex = 0;
            this.button_addProject.Text = "PROJE EKLE";
            this.button_addProject.UseVisualStyleBackColor = false;
            this.button_addProject.Click += new System.EventHandler(this.button1_Click);
            // 
            // Project_AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_middle);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Project_AddNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project_AddNew";
            this.Load += new System.EventHandler(this.Project_AddNew_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_middle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_personel)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_middle;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Button button_addProject;
        private System.Windows.Forms.TextBox textBox_prjname;
        private System.Windows.Forms.Label label_projects;
        private System.Windows.Forms.DataGridView dataGridView_personel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personel_name;
    }
}