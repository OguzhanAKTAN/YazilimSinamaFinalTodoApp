using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaFinal
{
    public class Project
    {
        public int projectid { get; private set; }
        public string projectname { get; private set; }
        public Button button { get; set; }
        public List<Personel> personels { get; set; }

        public Project(int id ,string name)
        {
            this.projectid = id;
            this.projectname = name;
        }
    }
}
