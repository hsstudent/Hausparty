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

        int laenge_X, laenge_Y;
        int schritte_X, schritte_Y;
        int genauigkeit = Karte.bewGenauigkeit;

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

        public Haus Haus
        {
            get
            {
                return haus;
            }

            set
            {
                haus = value;
            }
        }


        public int Laenge_X
        {
            get
            {
                return laenge_X;
            }

            set
            {
                laenge_X = value;
            }
        }


        public int Schritte_X
        {
            get
            {
                return schritte_X;
            }

            set
            {
                schritte_X = value;
            }
        }

        public int Schritte_Y
        {
            get
            {
                return schritte_Y;
            }

            set
            {
                schritte_Y = value;
            }
        }

        public int Laenge_Y
        {
            get
            {
                return laenge_Y;
            }

            set
            {
                laenge_Y = value;
            }
        }

        public int Genauigkeit
        {
            get
            {
                return genauigkeit;
            }

            set
            {
                genauigkeit = value;
            }
        }

        public Strecke(Punkt a, Punkt b)
        {

            laenge_X = Math.Abs(b.X - a.X);
            laenge_Y = Math.Abs(b.Y - a.Y);
            punkte.Add(a);
            punkte.Add(b);

            while(laenge_X % genauigkeit != 0)
            {
                genauigkeit -= 1;
            }
            schritte_X = laenge_X / genauigkeit;

            while (laenge_Y % genauigkeit != 0)
            {
                genauigkeit -= 1;
            }
            schritte_Y = laenge_Y / genauigkeit;
        }
    }
}
