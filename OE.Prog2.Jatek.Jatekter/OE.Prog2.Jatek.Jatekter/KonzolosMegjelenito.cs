using OE.Prog2.Jatek.Megjelenites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Jatekter
{
    internal class KonzolosMegjelenito
    {
        IMegjelenitheto forras;
        int pozX;
        int pozY;

        public KonzolosMegjelenito(IMegjelenitheto forras, int pozX, int pozY)
        {
            this.forras = forras;
            this.pozX = pozX;
            this.pozY = pozY;
        }
        public void Megjelenites()
        {
            forras.MegjelenítendőElemek();
            
            for (int i = 0; i < forras.MegjelenitendoMeret[0]; i++)
            {
                for (int j = 0; j < forras.MegjelenitendoMeret[1]; j++)
                {
                   if(forras.MegjelenítendőElemek()) 
                }
            }
        }
    }
}
