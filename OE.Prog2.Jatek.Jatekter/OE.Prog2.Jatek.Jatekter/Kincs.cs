using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    internal class Kincs : RogzitettJatekElem
    {
        public Kincs(int x, int y, JatekTer tér) : base(x, y, tér)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public override double Meret
        {
            get { return 1; }
        }

        public override void Utkozes(JatekElem jatekElem)
        {
            if(jatekElem is Jatekos)
            {
                ((Jatekos)jatekElem).PontotSzerez(50);
                Console.WriteLine(((Jatekos)jatekElem).Név);
                this.ter.Torles(this);
            }
        }

    }
}
