namespace YazilimSinamaFinal
{
    partial class ScrumBoard
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
            this.components = new System.ComponentModel.Container();
            this.panel_todo = new System.Windows.Forms.Panel();
            this.CardContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movetoToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.movetoInProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.movetoRevision = new System.Windows.Forms.ToolStripMenuItem();
            this.movetoCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.movetoDone = new System.Windows.Forms.ToolStripMenuItem();
            this.label_projects = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniProjeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buProjeyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAYDETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_inprogress = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_revision = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_check = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_done = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_addpersonel = new System.Windows.Forms.Button();
            this.CardContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_todo
            // 
            this.panel_todo.AllowDrop = true;
            this.panel_todo.AutoScroll = true;
            this.panel_todo.Location = new System.Drawing.Point(-1, 84);
            this.panel_todo.Name = "panel_todo";
            this.panel_todo.Size = new System.Drawing.Size(300, 616);
            this.panel_todo.TabIndex = 1;
            this.panel_todo.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel_todo.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.panel_todo.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // CardContextMenu
            // 
            this.CardContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CardContextMenu.Name = "contextMenuStrip1";
            this.CardContextMenu.Size = new System.Drawing.Size(97, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movetoToDo,
            this.movetoInProgress,
            this.movetoRevision,
            this.movetoCheck,
            this.movetoDone});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem1.Text = "TAŞI";
            // 
            // movetoToDo
            // 
            this.movetoToDo.Name = "movetoToDo";
            this.movetoToDo.Size = new System.Drawing.Size(132, 22);
            this.movetoToDo.Text = "To Do";
            this.movetoToDo.Click += new System.EventHandler(this.movetoToDo_Click);
            // 
            // movetoInProgress
            // 
            this.movetoInProgress.Name = "movetoInProgress";
            this.movetoInProgress.Size = new System.Drawing.Size(132, 22);
            this.movetoInProgress.Text = "In Progress";
            this.movetoInProgress.Click += new System.EventHandler(this.movetoInProgress_Click);
            // 
            // movetoRevision
            // 
            this.movetoRevision.Name = "movetoRevision";
            this.movetoRevision.Size = new System.Drawing.Size(132, 22);
            this.movetoRevision.Text = "Revision";
            this.movetoRevision.Click += new System.EventHandler(this.movetoRevision_Click);
            // 
            // movetoCheck
            // 
            this.movetoCheck.Name = "movetoCheck";
            this.movetoCheck.Size = new System.Drawing.Size(132, 22);
            this.movetoCheck.Text = "Check";
            this.movetoCheck.Click += new System.EventHandler(this.movetoCheck_Click);
            // 
            // movetoDone
            // 
            this.movetoDone.Name = "movetoDone";
            this.movetoDone.Size = new System.Drawing.Size(132, 22);
            this.movetoDone.Text = "Done";
            this.movetoDone.Click += new System.EventHandler(this.movetoDone_Click);
            // 
            // label_projects
            // 
            this.label_projects.AllowDrop = true;
            this.label_projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_projects.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_projects.ForeColor = System.Drawing.Color.White;
            this.label_projects.Location = new System.Drawing.Point(3, 0);
            this.label_projects.Name = "label_projects";
            this.label_projects.Size = new System.Drawing.Size(298, 58);
            this.label_projects.TabIndex = 1;
            this.label_projects.Text = "TODO";
            this.label_projects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.pERSONELToolStripMenuItem,
            this.kAYDETToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1504, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROJEToolStripMenuItem,
            this.anaMenüToolStripMenuItem});
            this.mENUToolStripMenuItem.Image = global::YazilimSinamaFinal.Properties.Resources.icons8_squared_menu_50;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // pROJEToolStripMenuItem
            // 
            this.pROJEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniProjeEkleToolStripMenuItem,
            this.buProjeyiSilToolStripMenuItem});
            this.pROJEToolStripMenuItem.Name = "pROJEToolStripMenuItem";
            this.pROJEToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pROJEToolStripMenuItem.Text = "PROJE";
            // 
            // yeniProjeEkleToolStripMenuItem
            // 
            this.yeniProjeEkleToolStripMenuItem.Name = "yeniProjeEkleToolStripMenuItem";
            this.yeniProjeEkleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yeniProjeEkleToolStripMenuItem.Text = "Yeni Proje Ekle";
            // 
            // buProjeyiSilToolStripMenuItem
            // 
            this.buProjeyiSilToolStripMenuItem.Name = "buProjeyiSilToolStripMenuItem";
            this.buProjeyiSilToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.buProjeyiSilToolStripMenuItem.Text = "Bu Projeyi Sil";
            // 
            // anaMenüToolStripMenuItem
            // 
            this.anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            this.anaMenüToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.anaMenüToolStripMenuItem.Text = "Ana Menü";
            // 
            // pERSONELToolStripMenuItem
            // 
            this.pERSONELToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem});
            this.pERSONELToolStripMenuItem.Image = global::YazilimSinamaFinal.Properties.Resources.icons8_team_60;
            this.pERSONELToolStripMenuItem.Name = "pERSONELToolStripMenuItem";
            this.pERSONELToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.pERSONELToolStripMenuItem.Text = "PERSONEL";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            // 
            // kAYDETToolStripMenuItem
            // 
            this.kAYDETToolStripMenuItem.Image = global::YazilimSinamaFinal.Properties.Resources.icons8_save_50;
            this.kAYDETToolStripMenuItem.Name = "kAYDETToolStripMenuItem";
            this.kAYDETToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kAYDETToolStripMenuItem.Text = "KAYDET";
            // 
            // panel_inprogress
            // 
            this.panel_inprogress.AllowDrop = true;
            this.panel_inprogress.AutoScroll = true;
            this.panel_inprogress.Location = new System.Drawing.Point(299, 84);
            this.panel_inprogress.Name = "panel_inprogress";
            this.panel_inprogress.Size = new System.Drawing.Size(300, 616);
            this.panel_inprogress.TabIndex = 3;
            this.panel_inprogress.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel_inprogress.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.panel_inprogress.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "IN PROGRESS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_revision
            // 
            this.panel_revision.AllowDrop = true;
            this.panel_revision.AutoScroll = true;
            this.panel_revision.Location = new System.Drawing.Point(599, 84);
            this.panel_revision.Name = "panel_revision";
            this.panel_revision.Size = new System.Drawing.Size(300, 616);
            this.panel_revision.TabIndex = 4;
            this.panel_revision.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel_revision.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.panel_revision.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(601, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "REVISION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_check
            // 
            this.panel_check.AllowDrop = true;
            this.panel_check.AutoScroll = true;
            this.panel_check.Location = new System.Drawing.Point(899, 84);
            this.panel_check.Name = "panel_check";
            this.panel_check.Size = new System.Drawing.Size(300, 616);
            this.panel_check.TabIndex = 5;
            this.panel_check.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel_check.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.panel_check.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(901, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 57);
            this.label3.TabIndex = 1;
            this.label3.Text = "CHECK";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_done
            // 
            this.panel_done.AllowDrop = true;
            this.panel_done.AutoScroll = true;
            this.panel_done.Location = new System.Drawing.Point(1199, 84);
            this.panel_done.Name = "panel_done";
            this.panel_done.Size = new System.Drawing.Size(305, 616);
            this.panel_done.TabIndex = 5;
            this.panel_done.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel_done.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.panel_done.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1204, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 58);
            this.label4.TabIndex = 1;
            this.label4.Text = "DONE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_addpersonel);
            this.panel1.Controls.Add(this.label_projects);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 58);
            this.panel1.TabIndex = 6;
            // 
            // button_addpersonel
            // 
            this.button_addpersonel.FlatAppearance.BorderSize = 0;
            this.button_addpersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addpersonel.Image = global::YazilimSinamaFinal.Properties.Resources.icons8_plus_64;
            this.button_addpersonel.Location = new System.Drawing.Point(3, 3);
            this.button_addpersonel.Name = "button_addpersonel";
            this.button_addpersonel.Size = new System.Drawing.Size(62, 55);
            this.button_addpersonel.TabIndex = 19;
            this.button_addpersonel.UseVisualStyleBackColor = true;
            this.button_addpersonel.Click += new System.EventHandler(this.button_addpersonel_Click);
            // 
            // ScrumBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1504, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_done);
            this.Controls.Add(this.panel_check);
            this.Controls.Add(this.panel_revision);
            this.Controls.Add(this.panel_inprogress);
            this.Controls.Add(this.panel_todo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScrumBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ScrumBoard";
            this.Load += new System.EventHandler(this.ScrumBoard_Load);
            this.CardContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_todo;
        private System.Windows.Forms.Label label_projects;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROJEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniProjeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buProjeyiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.Panel panel_inprogress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_revision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_done;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip CardContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movetoToDo;
        private System.Windows.Forms.ToolStripMenuItem movetoInProgress;
        private System.Windows.Forms.ToolStripMenuItem movetoRevision;
        private System.Windows.Forms.ToolStripMenuItem movetoCheck;
        private System.Windows.Forms.ToolStripMenuItem movetoDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem kAYDETToolStripMenuItem;
        private System.Windows.Forms.Button button_addpersonel;
    }
}