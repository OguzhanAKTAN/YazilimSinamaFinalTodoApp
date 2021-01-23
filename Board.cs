using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaFinal
{
    public class Board
    {
        public Project project;
        public List<ScrumCard> cards;
        public Board(Project project)
        {
            this.project = project;
            cards = new List<ScrumCard> { };
        }
        public void SetCards()
        {
            this.cards = DataBaseQueries.GetProjectCards(this.project);
        }
    }
}
