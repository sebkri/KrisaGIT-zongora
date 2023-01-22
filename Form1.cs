using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1 : Form
    {
        /* Függvények */

        void BILLENTYU(double lepeskoz, float tollmeret, int sorszam)
        {
            Tollvastagság(tollmeret);
            Tollszín(Color.Black);

            if ((sorszam != 3) && (sorszam != 7)) //FEKETE BILLENTYŰVEL
            {
                Előre(lepeskoz * 10); //fehér bal oldala
                Jobbra(90); Előre(lepeskoz*2); //fehér felső oldala
                Jobbra(90); //fekete billentyű kezdete
                Tollvastagság(tollmeret * 15); // vastag fekete billentyű
                Előre(lepeskoz * 7); //fekete billentyű
                Tollvastagság(tollmeret);
                Előre(lepeskoz * 3); // fekete alatti fehér jobb oldala
                Jobbra(90); Előre(lepeskoz * 2);//fehér alja vissza a kezdőpontig

                Fordulj(180);
                Előre(lepeskoz * 2);
                Balra(90); //következő billentyűzet kezdőpontja
            }

            else // FEHÉR BILLENYTŰVEL
            {
                Előre(lepeskoz * 10); //fehér bal oldala
                Jobbra(90); Előre(lepeskoz * 2); //fehér felső oldala
                Jobbra(90); //fehér bal kezdete
                Előre(lepeskoz * 10); // fehér jobb oldala
                Jobbra(90); Előre(lepeskoz * 2);//fehér alja vissza a kezdőpontig

                Fordulj(180);
                Előre(lepeskoz * 2);
                Balra(90); //következő billentyűzet kezdőpontja            
            }
        }

        /* Függvények vége */
        void FELADAT()
        {
            double lepeskoz = 10; //alakzat oldalának hossza
            float tolvastagsag = 1;
            int bill_szama = 7;// egy sorban mennyi legyen
            int ismetles = 4;
            
            Teleport(közép.X-300, közép.Y+100, észak); //kurzor elhelyezése induláskor

            for (int j =1;j<=4;j++) // a 7 billentyű ismétlése
            {
                for (int i = 1; i <= bill_szama; i++) // a 7 billentyű rajzolása
                {
                    int sorszam = i;
                    BILLENTYU(lepeskoz, tolvastagsag, sorszam);
                }

            }

        }
    }
}
