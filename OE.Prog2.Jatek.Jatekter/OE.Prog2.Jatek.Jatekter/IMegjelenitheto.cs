using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Megjelenites
{
    internal interface IMegjelenitheto
    {
        public int[] MegjelenitendoMeret{ 
            get
            {
                return new int[2];
            }  }
        public IKirajzolhato[] MegjelenítendőElemek();
    }
}
