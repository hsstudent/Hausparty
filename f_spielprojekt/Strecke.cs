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
        PictureBox1 pB;                                                     // Speichert die Bilder der Weichen in die dazugehörigen Strecken
        Haus haus;

        int laenge_X, laenge_Y;                                             // Länge der Strecke in Pixel
        int schritte_X, schritte_Y;                                         // Gibt an, wieviel Schritte eine Strecke hat
        int genauigkeit = Karte.bewGenauigkeit;                             // Gibt an, ob jeder Pixel abgelaufen werden soll, oder nur ein Teil der Pixel

        public Strecke(Punkt a, Punkt b)                                    // Berechnung der Schrittte, Genauigkeit kann eingestellt werden
        {
            laenge_X = Math.Abs(b.X - a.X);
            laenge_Y = Math.Abs(b.Y - a.Y);
            punkte.Add(a);
            punkte.Add(b);

            while (laenge_X % genauigkeit != 0)
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

        public List<Punkt> Punkte
        {
            get { return punkte; }
            set { punkte = value; }
        }

        public PictureBox1 PB                               
        {
            get { return pB; }
            set { pB = value; }
        }

        public Haus Haus
        {
            get { return haus; }
            set { haus = value; }
        }

        public int Laenge_X
        {
            get { return laenge_X; }
            set { laenge_X = value; }
        }
         
        public int Schritte_X
        {
            get { return schritte_X; }
            set { schritte_X = value; }
        }

        public int Schritte_Y
        {
            get { return schritte_Y; }
            set { schritte_Y = value; }
        }

        public int Laenge_Y
        {
            get { return laenge_Y; }
            set { laenge_Y = value; }
        }

        public int Genauigkeit
        {
            get { return genauigkeit; }
        }
    }
}
