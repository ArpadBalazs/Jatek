using OE.Prog2.Jatek.Jatekter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Szabalyok
{
    internal class Fal : RogzitettJatekElem
    {
        public Fal(int x, int y, JatekTer tér) : base(x, y, tér)
        {
        }
        public override double Meret
        {
            get
            {
                return 1;
            }
        }
        public override void Utkozes(JatekElem jatekElem)
        {
           
        }

    }
}
