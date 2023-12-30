using OE.Prog2.Jatek.Jatekter;
using OE.Prog2.Jatek.Szabalyok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OE.Prog2.Jatek.Keret
{
    internal class Keret
    {

        const int PALYA_MERET_X= 21;
        const int PALYA_MERET_Y = 11;
        const int KINCSEK_SZAMA = 10;
        JatekTer ter;
        bool jatekVege;


        public Keret()
        {
            ter=new JatekTer(PALYA_MERET_X, PALYA_MERET_Y);
            PalyaGeneralas();
        }

        private void PalyaGeneralas()
        {
            Fal[] felsőfalak=new Fal[ter.MeretX];
            for (int i = 0; i < ter.MeretX; i++)
            {
                felsőfalak[i] = new Fal(i, ter.MeretY, ter);
            }
            Fal[] baloldalifalak = new Fal[ter.MeretY-1];
            for (int i = 1; i < ter.MeretY; i++)
            {
                baloldalifalak[i] = new Fal(0, i, ter);
            }
            Fal[] jobboldalifalak = new Fal[ter.MeretY-1];
            for (int i = 1; i < ter.MeretY; i++)
            {
                jobboldalifalak[i] = new Fal(ter.MeretX, i, ter);
            }
            Fal[] alsófalak = new Fal[ter.MeretX];
            for (int i = 1; i < ter.MeretX-1; i++)
            {
                alsófalak[i] = new Fal(i, 0, ter);
            }
            Kincs[] kincsek=new Kincs[KINCSEK_SZAMA];
            for (int i = 0; i < KINCSEK_SZAMA; i++)
            {
                Random randomx = new Random();
                Random randomy = new Random();
                int x=randomx.Next(1, ter.MeretX - 1);
                int y =randomy.Next(1, ter.MeretY - 1);
                bool flag=true;
                for (int j = 0; j < kincsek.Length; j++)
                {
                    if (kincsek[j].X == x && kincsek[j].Y== y)
                    {
                        flag= false;
                        i--;
                        break;
                    }
                }
                if (flag&&x != 1 && y != 1)
                {
                    kincsek[i] = new Kincs(x, y, ter);
                }
                
            }
        }
        public void Futtatas()
        {
            Jatekos jatekos = new Jatekos("Béla", 1, 1, ter);
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow) jatekos.Megy(-1, 0);
                if (key.Key == ConsoleKey.RightArrow) jatekos.Megy(1, 0);
                if (key.Key == ConsoleKey.UpArrow) jatekos.Megy(0, -1);
                if (key.Key == ConsoleKey.DownArrow) jatekos.Megy(0, 1);
                if (key.Key == ConsoleKey.Escape) jatekVege = true;
            } while (!jatekVege);
        }
    }
}
