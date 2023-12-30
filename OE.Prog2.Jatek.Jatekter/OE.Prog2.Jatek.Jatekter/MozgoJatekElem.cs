using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    internal class MozgoJatekElem : JatekElem
    {
        public MozgoJatekElem(int x, int y, JatekTer tér) : base(x, y, tér)
        {
        }
        bool aktiv;
        public bool Aktiv { get
            {
                return aktiv;
            }
            set
            {
                aktiv = value;
            } }
        public void AtHelyez(int ujx,int ujy)
        {
            if (this.ter.MegadottHelyenLevok2(ujx, ujy).Length != null)
            {
                JatekElem[] jatekelemek=this.ter.MegadottHelyenLevok2(ujx, ujy);
                for (int i = 0; i < jatekelemek.Length;)
                {
                    this.ter.MegadottHelyenLevok2(ujx, ujy)[i].Utkozes(this);
                    this.Utkozes(this.ter.MegadottHelyenLevok2(ujx, ujy)[i]);
                    if (this.aktiv==true)
                    {
                        jatekelemek = this.ter.MegadottHelyenLevok2(ujx, ujy);
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                double szum = 0;
                for (int i = 0; i < jatekelemek.Length; i++)
                {
                    szum += jatekelemek[i].Meret;
                }
                szum += this.Meret;
                if (szum <= 1)
                {
                    this.X=ujx; this.Y=ujy;
                }
            }
        }
    }
}
