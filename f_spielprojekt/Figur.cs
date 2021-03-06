﻿using System;
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

        /// <summary>
        /// Erhöht den X und Y Wert der aktuellen Position. Alle Männchen laufen einen Schritt weiter. Das Männchen wird neu gezeichnet.
        /// Wenn das Ende des Weges erreicht ist, soll false zurück gegeben werden, d.h. die Strecke ist zu Ende.
        /// </summary>
        /// <returns></returns>
        public bool laufeStrecke()
        {
            if(meineStrecke.Genauigkeit != schritt)
            {

                meinPanel.Location = new Point(meinPanel.Location.X + meineStrecke.Schritte_X, meinPanel.Location.Y - meineStrecke.Schritte_Y);
                //meinPanel.BringToFront();
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
