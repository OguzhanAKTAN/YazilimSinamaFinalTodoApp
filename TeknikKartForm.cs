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
    public partial class TeknikKartForm : Form
    {
        ScrumCard card;
        Project current;
        public TeknikKartForm()
        {
            InitializeComponent();
        }
        public TeknikKartForm(Project project)
        {
            InitializeComponent();
            this.current = project;
            button_delete_card.Visible = false;
            button_update_card.Visible = false;
            card = new ScrumCard();
            foreach (Personel personel in project.personels)
            {
                listBox_projectpersonel.Items.Add(personel);
            }
        }
        private void CalculateTime()
        {
            int toplamis = dataGridView_takip.Rows.Count * 4;
            double isgucu = card.cardpersonel.Count * 1.5;
            double time = toplamis / isgucu;
            label_calculate.Text = time.ToString("0.0") +" saat";
        }
        public TeknikKartForm(int cardid,List<Personel> personels)
        {
            InitializeComponent();
            button_add_card.Visible = false;
            card = DataBaseQueries.GetCardDetails(cardid);
            textBox_cardname.Text = card.cardname;
            label_cardno.Text = card.cardid.ToString();
            label_cardname.Text = card.cardname;
            textBox_desc.Text = card.description;
            textBox_notes.Text = card.notes;
            label_card_date.Text = card.date.ToString("MM/dd/yyyy");
            foreach (IsTakip takip in card.isTakiplist)
            {
                dataGridView_takip.Rows.Add(takip.date, takip.durum, takip.yapilacak, takip.aciklama);
            }
            personels = personels.Except(card.cardpersonel,new PersonelEqualityComparer()).ToList();
            foreach(Personel personel1 in personels)
            {
                listBox_projectpersonel.Items.Add(personel1);
            }
            foreach (Personel personel in card.cardpersonel)
            {
                listBox_cardpersonel.Items.Add(personel);
            }
            CalculateTime();
        }

        private void button_addpersonel_Click(object sender, EventArgs e)
        {
            Personel selected = (Personel)listBox_projectpersonel.SelectedItem;
            if (selected!=null)
            {
                listBox_cardpersonel.Items.Add(selected);
                card.cardpersonel.Add(selected);
                listBox_projectpersonel.Items.Remove(selected);
            }
            CalculateTime();
        }

        private void button_removepersonel_Click(object sender, EventArgs e)
        {
            Personel selected = (Personel)listBox_cardpersonel.SelectedItem;
            if (selected != null)
            {
                listBox_projectpersonel.Items.Add(selected);
                card.cardpersonel.Remove(selected);
                listBox_cardpersonel.Items.Remove(selected);
            }
            CalculateTime();
        }

        private void button_update_card_Click(object sender, EventArgs e)
        {
            card.cardname = textBox_cardname.Text;
            card.description = textBox_desc.Text;
            card.notes = textBox_notes.Text;
            card.isTakiplist.Clear();
            foreach (DataGridViewRow row in dataGridView_takip.Rows)
            {
                card.isTakiplist.Add(new IsTakip(card.cardid, (DateTime)row.Cells[0].Value, (string)row.Cells[1].Value, (string)row.Cells[2].Value, (string)row.Cells[3].Value));
            }
            DataBaseQueries.UpdateCard(card);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_takip.Rows.Add(dateTimePicker1.Value);
            CalculateTime();
        }

        private void button_add_card_Click(object sender, EventArgs e)
        {
            card = new ScrumCard(current.projectid, "panel_todo", DateTime.Today, textBox_desc.Text, textBox_notes.Text, textBox_cardname.Text);
            foreach (Personel item in listBox_cardpersonel.Items)
            {
                card.cardpersonel.Add(item);
            }
            foreach (DataGridViewRow row in dataGridView_takip.Rows)
            {
                card.isTakiplist.Add(new IsTakip(card.cardid, (DateTime)row.Cells[0].Value, (string)row.Cells[1].Value, (string)row.Cells[2].Value, (string)row.Cells[3].Value));
            }
            DataBaseQueries.AddNewCardToProject(card);
            this.Close();
        }
    }
}
