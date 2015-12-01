using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F_Spielprojekt
{
    public class Figur : SpielObjekt
    {
        private Strecke meineStrecke;
        private int schritt = 0;
        public Figur(Farbe farbe, Karte meineKarte)
            : base (farbe)
        {
            PictureBox1 meinBild = new PictureBox1();
        }

        public Strecke MeineStrecke
        {
            get
            {
                return meineStrecke;
            }

            set
            {
                meineStrecke = value;
            }
        }

        public bool laufeStrecke()
        {
            if(meineStrecke.Schritte != schritt)
            {
                MeinBild.Location = new System.Drawing.Point(meinBild.Location.X + meineStrecke.Schritte, meinBild.Location.Y);
                schritt += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
