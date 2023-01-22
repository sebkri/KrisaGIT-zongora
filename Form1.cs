using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1 : Form
    {
        /* Függvények */


        void ROMBUSZ(double lepeskoz, float tollmeret)
        {
            Tollvastagság(tollmeret);
            Tollszín(Color.Black);

            Balra(30); Előre(lepeskoz); //rombusz megrajzolása, eredetileg felfelé néz az avatar
            Jobbra(60); Előre(lepeskoz);
            Jobbra(120); Előre(lepeskoz);
            Jobbra(60); Előre(lepeskoz);

            // negyzetátlók megrajzolása
            //double negyzetoldala = 3 * lepeskoz; //megrajzolt ngyzet oldalának hossza
            //double atlohossz = Math.Sqrt(2 * negyzetoldala * negyzetoldala); // 2*a2 = c2
        }

        void fekvo_rombusz_kezdopont(double lepeskoz) {
            Tollszín(Color.Empty);
            Fordulj(180);
            Előre(lepeskoz);
            Jobbra(60);// fekvő rombusz kezdőpontjához lépés, jobbra néz az avatar
        }
        void allo_rombusz_kezdopont(double lepeskoz)
        {
            Tollszín(Color.Empty);
            Fordulj(180);
            Előre(lepeskoz);
            Balra(60);
            Előre(lepeskoz);
            Jobbra(90);
            Előre(lepeskoz);
            Balra(150); // álló rombusz kezdőpontjához lépés és felfelé néz az avatar
        }
        void FEKVO_UJSOR_KEZDOPONT(double lepeskoz, double alakzatszama)
        { // a következő sor kezdőpontjára mozgatása az avatartnak
            double rovid_atlo = lepeskoz;
            double hosszu_atlo = lepeskoz * Math.Sqrt(3); // matek alapján oldal * 3 négyzetgyöke

            Előre(hosszu_atlo + rovid_atlo * 0.5);
            Balra(90);
            Előre((hosszu_atlo + rovid_atlo) * alakzatszama + hosszu_atlo * 0.5);
            Fordulj(180); //ez ahhoz kell hogy a fekvo rombusz jól induljon
        }
        void ALLO_UJSOR_KEZDOPONT(double lepeskoz, double alakzatszama)
        { // a következő sor kezdőpontjára mozgatása az avatartnak
            double rovid_atlo = lepeskoz;
            double hosszu_atlo = lepeskoz * Math.Sqrt(3); // matek alapján oldal * 3 négyzetgyöke

            Balra(90);
            Előre(rovid_atlo * 0.5); //felfele lépés
            Balra(90); //oldalra vissza lépegetés
            Előre(hosszu_atlo *3.5 + rovid_atlo * 4);
            Jobbra(90); //ez ahhoz kell hogy az álló rombusz jól induljon
        }
        void ELSO_SORMINTA(double lepeskoz, float tolvastagsag, int alakzatszama)
        {
            for (int i = 1; i <= alakzatszama; i++)
            {
                ROMBUSZ(lepeskoz, tolvastagsag); // álló rombusz
                fekvo_rombusz_kezdopont(lepeskoz);
                ROMBUSZ(lepeskoz, tolvastagsag); // fekvő rombusz
                allo_rombusz_kezdopont(lepeskoz);
            }
            FEKVO_UJSOR_KEZDOPONT(lepeskoz, alakzatszama);
        }

        void MASODIK_SORMINTA(double lepeskoz,float tolvastagsag, int alakzatszama)
        {
            for (int i = 1; i <= alakzatszama; i++)
            {
                ROMBUSZ(lepeskoz, tolvastagsag); // fekvő rombusz
                allo_rombusz_kezdopont(lepeskoz);
                ROMBUSZ(lepeskoz, tolvastagsag); // álló rombusz
                fekvo_rombusz_kezdopont(lepeskoz);
            }
            ALLO_UJSOR_KEZDOPONT(lepeskoz, alakzatszama);
        }

        void SORKITOLTO (double lepeskoz, int alakzatszama)
        {
            double rovid_atlo = lepeskoz;
            double hosszu_atlo = lepeskoz * Math.Sqrt(3); // matek alapján oldal * 3 négyzetgyöke

            Tollszín(Color.Empty);
            Jobbra(90);
            Előre(hosszu_atlo * 0.5);
            Jobbra(90);
            Előre(rovid_atlo * 0.5);

            for(int i = 1; i<=alakzatszama; i++)
            Tölt(Color.AliceBlue);
            Balra(90);
            Előre(rovid_atlo);
            Jobbra(90);
            Balra(90);
            Előre(hosszu_atlo);

        }

        /* Függvények vége */
        void FELADAT()
        {
            double lepeskoz = 50; //alakzat oldalának hossza
            float tolvastagsag = 1;
            int alakzatszama = 4;// egy sorban mennyi legyen
            
            Teleport(közép.X-250, közép.Y+100, észak); //kurzor elhelyezése induláskor

            int sorok = 2;
            for (int j = 1; j <= sorok; j++)
            {
                ELSO_SORMINTA(lepeskoz, tolvastagsag, alakzatszama);
                MASODIK_SORMINTA(lepeskoz, tolvastagsag, alakzatszama);
                //SORKITOLTO(lepeskoz, alakzatszama);
            }

        }
    }
}
