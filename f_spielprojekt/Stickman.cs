using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace F_Spielprojekt
{
    public class Stickman : GeoObjekte
    {
        private int schritte;
        private SolidBrush myBrush = new SolidBrush(Color.Aqua);
        private Pen pen = new Pen(Color.Aqua);
        private Graphics g;
        public Stickman(Punkt meinPunkt, int schritte, SolidBrush myBrush, Pen pen, Graphics g)
            : base(meinPunkt)
        {
            this.myBrush = myBrush;
            this.pen = pen;
            this.g = g;
        }

        public int Schritte
        {
            get { return schritte; }
            set { schritte = value; }
        }

        public override void Zeichne(Pen pen, Graphics g)
        {
        }

        public SolidBrush MyBrush
        {
            get { return myBrush; }
        }

        public Pen Pen
        {
            get { return pen; }
        }

        public Graphics G
        {
            get { return g; }
        }

        public void Zeichne(int schritte)       // Zeichnet die Stickmans
        {
            schritte = (schritte % 6) + 1;
            

            if (schritte == 1)                                                           // Schritt ist für die animation zuständig (1 - 6)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinPunkt.X - 6, meinPunkt.Y + 15);     //linke Hand
                points[1] = new Point(meinPunkt.X - 4, meinPunkt.Y + 8);      // linker Ellenbogen
                points[2] = new Point(meinPunkt.X, meinPunkt.Y);               // Oberkörper mitte
                points[3] = new Point(meinPunkt.X + 4, meinPunkt.Y + 8);      // rechter Ellenbogen
                points[4] = new Point(meinPunkt.X + 9, meinPunkt.Y + 11);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinPunkt.X - 1, meinPunkt.Y + 20);      // Hüfte
                points[8] = new Point(meinPunkt.X - 3, meinPunkt.Y + 30);      // linkes Knie
                points[9] = new Point(meinPunkt.X - 7, meinPunkt.Y + 40);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinPunkt.X + 3, meinPunkt.Y + 30);     // rechtes Knie
                points[13] = new Point(meinPunkt.X + 5, meinPunkt.Y + 40);    // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9);
            }
            else if (schritte == 2)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinPunkt.X - 3, meinPunkt.Y + 16);      //linke Hand
                points[1] = new Point(meinPunkt.X - 2, meinPunkt.Y + 7);      // linker Ellenbogen
                points[2] = new Point(meinPunkt.X, meinPunkt.Y);               // Oberkörper mitte
                points[3] = new Point(meinPunkt.X + 4, meinPunkt.Y + 7);      // rechter Ellenbogen
                points[4] = new Point(meinPunkt.X + 5, meinPunkt.Y + 13);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinPunkt.X - 1, meinPunkt.Y + 20);      // Hüfte
                points[8] = new Point(meinPunkt.X - 2, meinPunkt.Y + 29);      // linkes Knie
                points[9] = new Point(meinPunkt.X - 7, meinPunkt.Y + 38);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinPunkt.X + 2, meinPunkt.Y + 30);     // rechtes Knie
                points[13] = new Point(meinPunkt.X + 3, meinPunkt.Y + 40);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 3, meinPunkt.Y - 10, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 3, meinPunkt.Y - 10, 9, 9);
            }
            else if (schritte == 3)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinPunkt.X - 1, meinPunkt.Y + 17);      //linke Hand
                points[1] = new Point(meinPunkt.X - 1, meinPunkt.Y + 7);      // linker Ellenbogen
                points[2] = new Point(meinPunkt.X, meinPunkt.Y);               // Oberkörper mitte
                points[3] = new Point(meinPunkt.X + 1, meinPunkt.Y + 7);      // rechter Ellenbogen
                points[4] = new Point(meinPunkt.X + 1, meinPunkt.Y + 15);      // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinPunkt.X - 1, meinPunkt.Y + 20);      // Hüfte
                points[8] = new Point(meinPunkt.X - 1, meinPunkt.Y + 29);      // linkes Knie
                points[9] = new Point(meinPunkt.X - 6, meinPunkt.Y + 36);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinPunkt.X + 1, meinPunkt.Y + 30);     // rechtes Knie
                points[13] = new Point(meinPunkt.X + 1, meinPunkt.Y + 40);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 3, meinPunkt.Y - 10, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 3, meinPunkt.Y - 10, 9, 9);
            }
            else if (schritte == 4)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinPunkt.X + 1, meinPunkt.Y + 17);     //linke Hand
                points[1] = new Point(meinPunkt.X, meinPunkt.Y + 7);         // linker Ellenbogen
                points[2] = new Point(meinPunkt.X, meinPunkt.Y);              // Oberkörper mitte
                points[3] = new Point(meinPunkt.X, meinPunkt.Y + 7);         // rechter Ellenbogen
                points[4] = new Point(meinPunkt.X - 1, meinPunkt.Y + 17);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinPunkt.X - 1, meinPunkt.Y + 20);      // Hüfte
                points[8] = new Point(meinPunkt.X, meinPunkt.Y + 28);          // linkes Knie
                points[9] = new Point(meinPunkt.X - 1, meinPunkt.Y + 37);      // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinPunkt.X, meinPunkt.Y + 30);         // rechtes Knie
                points[13] = new Point(meinPunkt.X - 1, meinPunkt.Y + 40);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9);
            }
            else if (schritte == 5)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinPunkt.X + 3, meinPunkt.Y + 15);      //linke Hand
                points[1] = new Point(meinPunkt.X + 1, meinPunkt.Y + 7);      // linker Ellenbogen
                points[2] = new Point(meinPunkt.X, meinPunkt.Y);               // Oberkörper mitte
                points[3] = new Point(meinPunkt.X - 1, meinPunkt.Y + 7);      // rechter Ellenbogen
                points[4] = new Point(meinPunkt.X - 3, meinPunkt.Y + 17);      // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinPunkt.X - 1, meinPunkt.Y + 20);      // Hüfte
                points[8] = new Point(meinPunkt.X + 1, meinPunkt.Y + 28);      // linkes Knie
                points[9] = new Point(meinPunkt.X + 1, meinPunkt.Y + 38);      // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinPunkt.X - 1, meinPunkt.Y + 30);     // rechtes Knie
                points[13] = new Point(meinPunkt.X - 3, meinPunkt.Y + 40);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9);
            }
            else if (schritte == 6)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinPunkt.X + 6, meinPunkt.Y + 13);     //linke Hand
                points[1] = new Point(meinPunkt.X + 2, meinPunkt.Y + 7);      // linker Ellenbogen
                points[2] = new Point(meinPunkt.X, meinPunkt.Y);               // Oberkörper mitte
                points[3] = new Point(meinPunkt.X - 2, meinPunkt.Y + 7);      // rechter Ellenbogen
                points[4] = new Point(meinPunkt.X - 5, meinPunkt.Y + 16);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinPunkt.X - 1, meinPunkt.Y + 20);      // Hüfte
                points[8] = new Point(meinPunkt.X + 2, meinPunkt.Y + 28);      // linkes Knie
                points[9] = new Point(meinPunkt.X + 5, meinPunkt.Y + 38);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinPunkt.X - 2, meinPunkt.Y + 30);     // rechtes Knie
                points[13] = new Point(meinPunkt.X - 5, meinPunkt.Y + 40);    // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9);
            }
        }
    }
}
