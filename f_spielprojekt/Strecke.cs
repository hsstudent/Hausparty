using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F_Spielprojekt
{
    public class Strecke
    {
        List<Punkt> punkte = new List<Punkt>();
        PictureBox1 pB;
        Haus haus;

        int laenge;
        int schritte;

        public int Laenge
        {
            get
            {
                return laenge;
            }

            set
            {
                laenge = value;
            }
        }

        public int Schritte
        {
            get
            {
                return schritte;
            }

            set
            {
                schritte = value;
            }
        }

        public List<Punkt> Punkte
        {
            get
            {
                return punkte;
            }

            set
            {
                punkte = value;
            }
        }

        public PictureBox1 PB
        {
            get
            {
                return pB;
            }

            set
            {
                pB = value;
            }
        }

        public Strecke(Punkt a, Punkt b)
        {
            Laenge = b.X - a.X;
            if (Laenge == 0)
            {
                Laenge = b.Y - a.Y;
            }
            while(Schritte % Karte.bewGenauigkeit != 0)
            {
                Karte.bewGenauigkeit -= 1;
            }
            Schritte = Laenge / Karte.bewGenauigkeit;
        }
    }
}
