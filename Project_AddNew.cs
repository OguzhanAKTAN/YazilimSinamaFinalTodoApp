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
    public partial class Project_AddNew : Form
    {
        public Project_AddNew()
        {
            InitializeComponent();
        }

        private void Project_AddNew_Load(object sender, EventArgs e)
        {
            List<Personel> personels = DataBaseQueries.GetAllPersonel();
            foreach (Personel personel in personels)
            {
                dataGridView_personel.Rows.Add(personel.personelid, personel.personelname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Personel> selected = new List<Personel> { };
            foreach (DataGridViewRow row in dataGridView_personel.Rows)
            {
                if (row.Selected)
                {
                    selected.Add(new Personel(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString()));
                }
            }
            DataBaseQueries.AddNewProject(textBox_prjname.Text, selected);
            this.Close();
        }
    }
}
