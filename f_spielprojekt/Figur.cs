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
        private Stickman stickman;

        public Figur(Pen pen, Karte meineKarte, Stickman stickman)
            : base (pen)
        {
            this.stickman = stickman;
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

        public Stickman Stickman
        {
            get { return stickman; }
        }
        public bool laufeStrecke()
        {
            if(meineStrecke.Genauigkeit != schritt)
            {
                //stickman.MeinePosition.X = stickman.MeinePosition.X + meineStrecke.Schritte_X;
                //stickman.MeinePosition.Y = stickman.MeinePosition.Y - meineStrecke.Schritte_Y;

                MeinPanel.Location = new Point(MeinPanel.Location.X + meineStrecke.Schritte_X, MeinPanel.Location.Y - meineStrecke.Schritte_Y);

                int walk = schritt+1;
           
                stickman.Zeichne(walk);

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
