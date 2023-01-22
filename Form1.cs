using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1 : Form
    {
        /* Függvények */

        
        void ROMBUSZ(double lepeskoz, float tollmeret, int irany)
        {
            Tollvastagság(tollmeret);
            Tollszín(Color.Black);
            Balra(irany); //megadjuk, hogy álló vagy fekvő rombuszt rajzolunk

            for (int i = 1; i <= 4; i++) //álló rombusz megrajzolása
            {
                Balra(30); Előre(lepeskoz);
                Jobbra(60); Előre(lepeskoz);
                Jobbra(120); Előre(lepeskoz);
                Jobbra(60); Előre(lepeskoz);
                Tollszín(Color.Black);
                Előre(lepeskoz);
                Jobbra(90);
            }

            // negyzetátlók megrajzolása
            double negyzetoldala = 3 * lepeskoz; //megrajzolt ngyzet oldalának hossza
            double atlohossz = Math.Sqrt(2 * negyzetoldala * negyzetoldala); // 2*a2 = c2

            Jobbra(45);
            Előre(atlohossz);
            Balra(135);
            Tollszín(Color.Empty);
            Előre(negyzetoldala);
            Balra(135);
            Tollszín(Color.Black);
            Előre(atlohossz);
            Balra(135);
        }

        void UJSORKEZDETE(double lepeskoz, double negyzetekszamaegysorban)
        { // a következő sor kezdőpontjára mozgatása az avatartnak

            double negyzetoldala = lepeskoz * 3; // egy oldal hossza a lépésköz háromszorosa
            Tollszín(Color.Empty);
            Előre(negyzetoldala); //felfelé haladva a rövid oldalon
            Balra(90);
            Előre(negyzetoldala * negyzetekszamaegysorban); //visszamegy az első négyzet bal csúcsához
            Jobbra(90);

        }

        /* Függvények vége */
        void FELADAT()
        {
            /* Ezt indítja a START gomb! */
            // Teleport(közép.X, közép.Y+150, észak);
            //Ív(90, 100);

            double lepeskoz = 30;
            float tolvastagsag = 10;
            int alakzatszama = 5;
            int sorok = 2;

            //for (int j = 1; j <= sorok; j++)
            //{
                for (int i = 1; i <= alakzatszama; i++)
                {
                ROMBUSZ(lepeskoz, tolvastagsag, 0);
                }
              //  UJSORKEZDETE(lepeskoz, negyzetekszama);
            //}

        }
    }
}
