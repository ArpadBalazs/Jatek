using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    abstract class JatekElem
    {
        public int X { get; set; }
        public int Y { get; set; }
        int x;
        int y;
        protected JatekTer ter;

        public abstract double Meret { get; }

        public abstract void Utkozes(JatekElem jatekElem);

        public JatekElem(int x, int y, JatekTer tér)
        {
            this.X = x;
            this.Y = y;
            ter = tér;
            tér.Felvetel(this);
        }

        public override string? ToString()
        {
            return this.X+" "+this.Y;
        }
    }
}
