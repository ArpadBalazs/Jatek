using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    internal class JatekTer
    {
        const int MAX_ELEMSZAM = 1000;
        int elemN=0;
        JatekElem[] elemek;
        int meretX;
        int meretY;

        public JatekTer(int meretX, int meretY)
        {
            this.meretX = meretX;
            this.meretY = meretY;
            elemek = new JatekElem[MAX_ELEMSZAM];
        }

        public int MeretX { get
            {
                return meretX;
            } }
        public int MeretY { get
            {
                return meretY;
            } }
        public void Felvetel(JatekElem játékelem)
        {
            elemek[elemN] = játékelem;
            elemN++;
        }
        public void Torles(JatekElem játékelem)
        {
            int indexToRemove = Array.IndexOf(elemek, játékelem);
            if (indexToRemove >= 0) 
            {
                JatekElem[] newArray = new JatekElem[elemek.Length - 1];
                for (int i = 0, j = 0; i < elemek.Length; i++)
                {
                    if (i != indexToRemove)
                    {
                        newArray[j++] = elemek[i];
                    }
                }
             this.elemek = newArray; 
            }
        }
        public JatekElem[] MegadottHelyenLevok(int x,int y, int távolság)
        {
            List<JatekElem> talalatok = new List<JatekElem>();
            foreach (JatekElem elem in elemek)
            {
                if (elem != null&&Math.Sqrt(Math.Pow(elem.X - x, 2) + Math.Pow(elem.Y - y, 2)) <= távolság)
                {
                    talalatok.Add(elem);
                }
            }
            return talalatok.ToArray();
        }
        public JatekElem[] MegadottHelyenLevok2(int x, int y)
        {
            List<JatekElem> talalatok = new List<JatekElem>();
            foreach (JatekElem elem in elemek)
            {
                if (elem != null && Math.Sqrt(Math.Pow(elem.X - x, 2) + Math.Pow(elem.Y - y, 2)) == 0)
                {
                    talalatok.Add(elem);
                }
            }
            return talalatok.ToArray();
        }
    }
}
