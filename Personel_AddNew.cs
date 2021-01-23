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
    public partial class Personel_AddNew : Form
    {
        public Personel_AddNew()
        {
            InitializeComponent();
        }

        private void button_addProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)==false)
            {
                DataBaseQueries.AddNewPersonel(textBox1.Text);
                MessageBox.Show(textBox1.Text + "Isimli personel basariyla eklendi!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lutfen personel ismi giriniz");
            }
        }
    }
}
