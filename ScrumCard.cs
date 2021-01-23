using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaFinal
{
    public class ScrumCard
    {
        public int cardid { get; set; }
        public int projectid { get; set; }
        public string cardname { get; set; }
        public string panelname { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        public string notes { get; set; }
        public Button button;
        public List<IsTakip> isTakiplist { get; set; }
        public List<Personel> cardpersonel { get; set; }

        public ScrumCard(int cardid,int projectid,string panelname,DateTime date,string desc,string notes,string cardname)
        {
            this.cardid = cardid;
            this.projectid = projectid;
            this.panelname = panelname;
            this.date = date;
            this.description = desc;
            this.notes = notes;
            this.cardname = cardname;

        }
        public ScrumCard(int projectid, string panelname, DateTime date, string desc, string notes, string cardname) 
        {
            this.projectid = projectid;
            this.panelname = panelname;
            this.date = date;
            this.description = desc;
            this.notes = notes;
            this.cardname = cardname;
            cardpersonel = new List<Personel> { };
            isTakiplist = new List<IsTakip> { };
        }
        public ScrumCard()
        {
            cardpersonel = new List<Personel> { };
            isTakiplist = new List<IsTakip> { };
        }

    }
}
