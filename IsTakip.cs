using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaFinal
{
    public class IsTakip
    {
        public int cardid { get; set; }
        public DateTime date { get; set; }
        public string durum { get; set; }
        public string yapilacak { get; set; }
        public string aciklama { get; set; }
        
        public IsTakip(int cardid,DateTime date,string durum,string yapilacak,string aciklama)
        {
            this.cardid = cardid;
            this.date = date;
            this.durum = durum;
            this.yapilacak = yapilacak;
            this.aciklama = aciklama;
        }
    }
}
