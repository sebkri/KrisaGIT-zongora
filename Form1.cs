using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1 : Form
    {
        /* Függvények */


        void BILLENTYU(double lepeskoz, float tollmeret)
        {
            Tollvastagság(tollmeret);
            Tollszín(Color.Black);

            Előre(lepeskoz * 10); //fehér bal oldala
            Jobbra(90); Előre(lepeskoz *2 ); //fehér felső oldala
            Jobbra(90); Előre(lepeskoz * 2); //fekete billentyű felett
            Tollvastagság(tollmeret * 10); // vastag fekete billentyű
            Jobbra(90); Előre(lepeskoz * 5); //fekete billentyű
            Tollvastagság(tollmeret);
            Előre(lepeskoz * 3); // fekete alatti fehér jobb oldala
            Jobbra(90); Előre(lepeskoz);//fehér alja vissza a kezdőpontig
            
            Fordulj(180);
            Előre(lepeskoz * 2);
            Balra(90); //következő billentyűzet kezdőpontja
        }
        


        /* Függvények vége */
        void FELADAT()
        {
            double lepeskoz = 10; //alakzat oldalának hossza
            float tolvastagsag = 1;
            int alakzatszama = 28;// egy sorban mennyi legyen
            
            Teleport(közép.X-300, közép.Y+100, észak); //kurzor elhelyezése induláskor

            for (int i = 1; i <= alakzatszama; i++)
            {
                BILLENTYU(lepeskoz, tolvastagsag);
                //SORKITOLTO(lepeskoz, alakzatszama);
            }

        }
    }
}
