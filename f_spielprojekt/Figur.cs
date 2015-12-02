﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F_Spielprojekt
{
    public class Figur : SpielObjekt
    {
        private Strecke meineStrecke;
        private int schritt;
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

        public int Schritt
        {
            get
            {
                return schritt;
            }

            set
            {
                schritt = value;
            }
        }

        public bool laufeStrecke()
        {
            if(meineStrecke.Genauigkeit != schritt)
            {
                MeinBild.Location = new System.Drawing.Point(meinBild.Location.X + meineStrecke.Schritte_X, meinBild.Location.Y - meineStrecke.Schritte_Y);
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
