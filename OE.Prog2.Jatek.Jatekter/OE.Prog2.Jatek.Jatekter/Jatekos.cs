using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    internal class Jatekos:MozgoJatekElem
    {
        string nev;

        public Jatekos(string nev,int x,int y,JatekTer tér):base(x,y,tér)
        {
            this.nev = nev;
        }

        public string Név { get
            {
                return nev;
            }
            }
        public double Meret { get
            {
                return 0.2;
            } }
        public override void Utkozes(JatekElem jatekElem)
        {

        }
        int eletero = 100;

        public void Serul(int serules)
        {
            if (eletero > 0)
            {
                eletero-=serules;
            }
            if (eletero <= 0)
            {
                eletero = 0;
                Aktiv = false;
            }
        }
        int pontszam = 0;
        public void PontotSzerez(int pont)
        {
            pontszam += pont;
        }
        public void Megy(int rx,int ry)
        {
            this.X += rx;
            this.Y += ry;
            this.AtHelyez(this.X,this.Y);
        }

    }
}
