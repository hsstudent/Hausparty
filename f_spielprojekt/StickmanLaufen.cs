using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace F_Spielprojekt
{
    public class StickmanLaufen : GeoObjekte
    {
        private int schritte;
        private SolidBrush myBrush = new SolidBrush(Color.Aqua);
        private Pen pen = new Pen(Color.Aqua);
        private Graphics g;
        public StickmanLaufen(Punkt meinePosition, int schritte, SolidBrush myBrush, Pen pen, Graphics g)
            : base(meinePosition)
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

        public void Zeichne(int schritte, StickmanLaufen st1)       // Zeichnet die Stickmans
        {
            SolidBrush myBrush = st1.MyBrush;
            Pen pen = st1.Pen;
            Graphics g = st1.G;
            schritte = (schritte % 6) + 1;
            g.Clear(Color.Transparent);

            if (schritte == 1)                                                           // Schritt ist für die animation zuständig (1 - 6)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinePosition.X - 6, PosY + 15);     //linke Hand
                points[1] = new Point(meinePosition.X - 4, PosY + 8);      // linker Ellenbogen
                points[2] = new Point(meinePosition.X, PosY);               // Oberkörper mitte
                points[3] = new Point(meinePosition.X + 4, PosY + 8);      // rechter Ellenbogen
                points[4] = new Point(meinePosition.X + 9, PosY + 11);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinePosition.X - 1, PosY + 20);      // Hüfte
                points[8] = new Point(meinePosition.X - 3, PosY + 30);      // linkes Knie
                points[9] = new Point(meinePosition.X - 7, PosY + 40);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinePosition.X + 3, PosY + 30);     // rechtes Knie
                points[13] = new Point(meinePosition.X + 5, PosY + 40);    // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinePosition.X - 2, PosY - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinePosition.X - 2, PosY - 9, 9, 9); 
            }
            else if (schritte == 2)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinePosition.X - 3, PosY + 16);      //linke Hand
                points[1] = new Point(meinePosition.X - 2, PosY + 7);      // linker Ellenbogen
                points[2] = new Point(meinePosition.X, PosY);               // Oberkörper mitte
                points[3] = new Point(meinePosition.X + 4, PosY + 7);      // rechter Ellenbogen
                points[4] = new Point(meinePosition.X + 5, PosY + 13);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinePosition.X - 1, PosY + 20);      // Hüfte
                points[8] = new Point(meinePosition.X - 2, PosY + 29);      // linkes Knie
                points[9] = new Point(meinePosition.X - 7, PosY + 38);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinePosition.X + 2, PosY + 30);     // rechtes Knie
                points[13] = new Point(meinePosition.X + 3, PosY + 40);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinePosition.X - 3, PosY - 10, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinePosition.X - 3, PosY - 10, 9, 9);
            }
            else if (schritte == 3)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinePosition.X - 1, PosY + 17);      //linke Hand
                points[1] = new Point(meinePosition.X - 1, PosY + 7);      // linker Ellenbogen
                points[2] = new Point(meinePosition.X, PosY);               // Oberkörper mitte
                points[3] = new Point(meinePosition.X + 1, PosY + 7);      // rechter Ellenbogen
                points[4] = new Point(meinePosition.X + 1, PosY + 15);      // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinePosition.X - 1, PosY + 20);      // Hüfte
                points[8] = new Point(meinePosition.X - 1, PosY + 29);      // linkes Knie
                points[9] = new Point(meinePosition.X - 6, PosY + 36);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinePosition.X + 1, PosY + 30);     // rechtes Knie
                points[13] = new Point(meinePosition.X + 1, PosY + 40);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinePosition.X - 3, PosY - 10, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinePosition.X - 3, PosY - 10, 9, 9);
            }
            else if (schritte == 4)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinePosition.X + 1, PosY + 17);     //linke Hand
                points[1] = new Point(meinePosition.X, PosY + 7);         // linker Ellenbogen
                points[2] = new Point(meinePosition.X, PosY);              // Oberkörper mitte
                points[3] = new Point(meinePosition.X, PosY + 7);         // rechter Ellenbogen
                points[4] = new Point(meinePosition.X - 1, PosY + 17);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinePosition.X - 1, PosY + 20);      // Hüfte
                points[8] = new Point(meinePosition.X, PosY + 28);          // linkes Knie
                points[9] = new Point(meinePosition.X - 1, PosY + 37);      // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinePosition.X, PosY + 30);         // rechtes Knie
                points[13] = new Point(meinePosition.X - 1, PosY + 40);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinePosition.X - 2, PosY - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinePosition.X - 2, PosY - 9, 9, 9);
            }
            else if (schritte == 5)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinePosition.X + 3, PosY + 15);      //linke Hand
                points[1] = new Point(meinePosition.X + 1, PosY + 7);      // linker Ellenbogen
                points[2] = new Point(meinePosition.X, PosY);               // Oberkörper mitte
                points[3] = new Point(meinePosition.X - 1, PosY + 7);      // rechter Ellenbogen
                points[4] = new Point(meinePosition.X - 3, PosY + 17);      // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinePosition.X - 1, PosY + 20);      // Hüfte
                points[8] = new Point(meinePosition.X + 1, PosY + 28);      // linkes Knie
                points[9] = new Point(meinePosition.X + 1, PosY + 38);      // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinePosition.X - 1, PosY + 30);     // rechtes Knie
                points[13] = new Point(meinePosition.X - 3, PosY + 40);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinePosition.X - 2, PosY - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinePosition.X - 2, PosY - 9, 9, 9);
            }
            else if (schritte == 6)
            {
                Point[] points = new Point[14];
                points[0] = new Point(meinePosition.X + 6, PosY + 13);     //linke Hand
                points[1] = new Point(meinePosition.X + 2, PosY + 7);      // linker Ellenbogen
                points[2] = new Point(meinePosition.X, PosY);               // Oberkörper mitte
                points[3] = new Point(meinePosition.X - 2, PosY + 7);      // rechter Ellenbogen
                points[4] = new Point(meinePosition.X - 5, PosY + 16);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(meinePosition.X - 1, PosY + 20);      // Hüfte
                points[8] = new Point(meinePosition.X + 2, PosY + 28);      // linkes Knie
                points[9] = new Point(meinePosition.X + 5, PosY + 38);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(meinePosition.X - 2, PosY + 30);     // rechtes Knie
                points[13] = new Point(meinePosition.X - 5, PosY + 40);    // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinePosition.X - 2, PosY - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinePosition.X - 2, PosY - 9, 9, 9);
            }
        }
    }
}
