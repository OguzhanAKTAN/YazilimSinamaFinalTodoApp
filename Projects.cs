using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaFinal
{
    public partial class Projects : Form
    {       
        public Projects()
        {
            InitializeComponent();
        }
        private void ClearButtons()
        {
            panel_projects.Controls.Clear();
            panel_personel.Controls.Clear();
        }
        private void FillButtons()
        {
            List<Project> projects = DataBaseQueries.GetProjects();
            foreach (Project project in projects)
            {
                project.button = new Button();
                project.button.Name = project.projectid.ToString();
                AddButtonToForm(project.button, panel_projects, project.projectname);
            }
            List<Personel> personels = DataBaseQueries.GetAllPersonel();
            foreach (Personel personel in personels)
            {
                AddButtonToForm(new Button(), panel_personel, personel.personelname);
            }
        }
        private void AddButtonToForm(Button button,Panel parent,string btntext)
        {
            this.Controls.Add(button);
            if (string.IsNullOrEmpty(button.Name)==false)
            {
                button.Click += new EventHandler(this.ProjectButton_Clicked);
            }          
            button.Size = new Size(353, 57);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Text = btntext;
            button.Visible = true;
            button.Parent = parent;
            button.BringToFront();
            button.Dock = DockStyle.Top;
        }
        void ProjectButton_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Project project = new Project(Convert.ToInt32(button.Name), button.Text);
            project.personels = DataBaseQueries.GetProjectPersonel(project);
            ScrumBoard board = new ScrumBoard(new Board(project));
            this.Hide();
            if (board.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        private void Projects_Load(object sender, EventArgs e)
        {
            FillButtons();
        }

        private void button_add_project_Click(object sender, EventArgs e)
        {
            Project_AddNew addNew = new Project_AddNew();
            if (addNew.ShowDialog() == DialogResult.Cancel)
            {
                ClearButtons();
                FillButtons();
            }
        }

        private void button_add_personel_Click(object sender, EventArgs e)
        {
            Personel_AddNew addNew = new Personel_AddNew();
            if (addNew.ShowDialog()==DialogResult.Cancel)
            {
                ClearButtons();
                FillButtons();
            }
        }
    }
}
