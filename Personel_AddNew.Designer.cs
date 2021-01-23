namespace YazilimSinamaFinal
{
    partial class Personel_AddNew
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
            this.label_projects = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_addProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_projects
            // 
            this.label_projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_projects.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_projects.ForeColor = System.Drawing.Color.White;
            this.label_projects.Location = new System.Drawing.Point(12, 9);
            this.label_projects.Name = "label_projects";
            this.label_projects.Size = new System.Drawing.Size(254, 28);
            this.label_projects.TabIndex = 2;
            this.label_projects.Text = "TEKNIK UZMAN ADI :";
            this.label_projects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button_addProject
            // 
            this.button_addProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.button_addProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_addProject.FlatAppearance.BorderSize = 0;
            this.button_addProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addProject.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.button_addProject.ForeColor = System.Drawing.Color.White;
            this.button_addProject.Location = new System.Drawing.Point(0, 63);
            this.button_addProject.Name = "button_addProject";
            this.button_addProject.Size = new System.Drawing.Size(791, 45);
            this.button_addProject.TabIndex = 4;
            this.button_addProject.Text = "EKLE";
            this.button_addProject.UseVisualStyleBackColor = false;
            this.button_addProject.Click += new System.EventHandler(this.button_addProject_Click);
            // 
            // Personel_AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(791, 108);
            this.Controls.Add(this.button_addProject);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_projects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Personel_AddNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel_AddNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_projects;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_addProject;
    }
}