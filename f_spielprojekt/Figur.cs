using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace F_Spielprojekt
{
    public class Figur : SpielObjekt
    {
        private Strecke meineStrecke;                   // Auf dieser Strecke befindet sich die Figur
        private int schritt;                            // Der Ort auf der jewiligen Stecke auf dem sich die Figur befindet
        private StickmanLaufen st1;
        public Figur(Pen pen, Karte meineKarte, StickmanLaufen st1)
            : base (pen)
        {
            this.st1 = st1;
        }

        public Strecke MeineStrecke
        {
            get { return meineStrecke; }
            set { meineStrecke = value; }
        }

        public int Schritt
        {
            get { return schritt; }
            set { schritt = value; }
        }

        public StickmanLaufen St1
        {
            get { return st1; }
        }
        public bool laufeStrecke(StickmanLaufen st1)
        {
            if(meineStrecke.Genauigkeit != schritt)
            {
                meinBild.Location = new System.Drawing.Point(meinBild.Location.X + meineStrecke.Schritte_X, meinBild.Location.Y - meineStrecke.Schritte_Y);
                int walk = schritt+1;

           
                st1.Zeichne(walk, st1);

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
