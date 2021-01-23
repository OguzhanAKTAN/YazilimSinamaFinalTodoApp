using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaFinal
{
    public class Personel
    {
        public int personelid { get; private set; }
        public string personelname { get; private set; }

        public Personel(int id,string name)
        {
            this.personelid = id;
            this.personelname = name;
        }
        public override string ToString()
        {
            return personelid.ToString()+"   "+personelname;
        }
    }
    class PersonelEqualityComparer : IEqualityComparer<Personel>
    {
        public bool Equals(Personel x, Personel y)
        {
            return x.personelid == y.personelid &&
                   x.personelname == y.personelname;
        }

        public int GetHashCode(Personel obj)
        {
            unchecked
            {
                if (obj == null)
                    return 0;
                int hashCode = obj.personelid.GetHashCode();
                hashCode = (hashCode * 397) ^ obj.personelid.GetHashCode();
                return hashCode;
            }
        }
    }
}
