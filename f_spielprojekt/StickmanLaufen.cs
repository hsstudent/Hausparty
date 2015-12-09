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
        public StickmanLaufen(int posX, int posY, int schritte, SolidBrush myBrush, Pen pen, Graphics g)
            : base(posX, posY)
        {
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

        public bool Zeichne(int schritte, StickmanLaufen st1)       // Zeichnet die Stickmans
        {
            SolidBrush myBrush = st1.MyBrush;
            Pen pen = st1.Pen;
            Graphics g = st1.G;

            if (schritte == 1)                                                           // Schritt ist für die animation zuständig (1 - 6)
            {
                Point[] points = new Point[14];
                points[0] = new Point(PosX - 12, PosY + 30);     //linke Hand
                points[1] = new Point(PosX - 8, PosY + 16);      // linker Ellenbogen
                points[2] = new Point(PosX, PosY);               // Oberkörper mitte
                points[3] = new Point(PosX + 8, PosY + 16);      // rechter Ellenbogen
                points[4] = new Point(PosX + 18, PosY + 22);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(PosX - 2, PosY + 40);      // Hüfte
                points[8] = new Point(PosX - 6, PosY + 60);      // linkes Knie
                points[9] = new Point(PosX - 14, PosY + 80);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(PosX + 6, PosY + 60);     // rechtes Knie
                points[13] = new Point(PosX + 10, PosY + 80);    // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, PosX - 4, PosY - 18, 18, 18); // Kopf
                g.FillEllipse(myBrush, PosX - 4, PosY - 18, 18, 18); 
                return true;
            }
            else if (schritte == 2)
            {
                Point[] points = new Point[14];
                points[0] = new Point(PosX - 6, PosY + 32);      //linke Hand
                points[1] = new Point(PosX - 4, PosY + 14);      // linker Ellenbogen
                points[2] = new Point(PosX, PosY);               // Oberkörper mitte
                points[3] = new Point(PosX + 4, PosY + 14);      // rechter Ellenbogen
                points[4] = new Point(PosX + 10, PosY + 26);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(PosX - 2, PosY + 40);      // Hüfte
                points[8] = new Point(PosX - 4, PosY + 58);      // linkes Knie
                points[9] = new Point(PosX - 14, PosY + 76);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(PosX + 4, PosY + 60);     // rechtes Knie
                points[13] = new Point(PosX + 6, PosY + 80);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, PosX - 6, PosY - 20, 18, 18); // Kopf
                g.FillEllipse(myBrush, PosX - 6, PosY - 20, 18, 18);
                return true;
            }
            else if (schritte == 3)
            {
                Point[] points = new Point[14];
                points[0] = new Point(PosX - 2, PosY + 34);      //linke Hand
                points[1] = new Point(PosX - 2, PosY + 14);      // linker Ellenbogen
                points[2] = new Point(PosX, PosY);               // Oberkörper mitte
                points[3] = new Point(PosX + 2, PosY + 14);      // rechter Ellenbogen
                points[4] = new Point(PosX + 2, PosY + 30);      // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(PosX - 2, PosY + 40);      // Hüfte
                points[8] = new Point(PosX - 2, PosY + 58);      // linkes Knie
                points[9] = new Point(PosX - 12, PosY + 72);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(PosX + 2, PosY + 60);     // rechtes Knie
                points[13] = new Point(PosX + 2, PosY + 80);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, PosX - 6, PosY - 20, 18, 18); // Kopf
                g.FillEllipse(myBrush, PosX - 6, PosY - 20, 18, 18);
                return true;
            }
            else if (schritte == 4)
            {
                Point[] points = new Point[14];
                points[0] = new Point(PosX + 2, PosY + 34);     //linke Hand
                points[1] = new Point(PosX, PosY + 14);         // linker Ellenbogen
                points[2] = new Point(PosX, PosY);              // Oberkörper mitte
                points[3] = new Point(PosX, PosY + 14);         // rechter Ellenbogen
                points[4] = new Point(PosX - 2, PosY + 34);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(PosX - 2, PosY + 40);      // Hüfte
                points[8] = new Point(PosX, PosY + 56);          // linkes Knie
                points[9] = new Point(PosX - 2, PosY + 74);      // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(PosX, PosY + 60);         // rechtes Knie
                points[13] = new Point(PosX - 2, PosY + 80);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, PosX - 4, PosY - 18, 18, 18); // Kopf
                g.FillEllipse(myBrush, PosX - 4, PosY - 18, 18, 18);
                return true;
            }
            else if (schritte == 5)
            {
                Point[] points = new Point[14];
                points[0] = new Point(PosX + 6, PosY + 30);      //linke Hand
                points[1] = new Point(PosX + 2, PosY + 14);      // linker Ellenbogen
                points[2] = new Point(PosX, PosY);               // Oberkörper mitte
                points[3] = new Point(PosX - 2, PosY + 14);      // rechter Ellenbogen
                points[4] = new Point(PosX - 6, PosY + 34);      // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(PosX - 2, PosY + 40);      // Hüfte
                points[8] = new Point(PosX + 2, PosY + 56);      // linkes Knie
                points[9] = new Point(PosX + 2, PosY + 76);      // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(PosX - 2, PosY + 60);     // rechtes Knie
                points[13] = new Point(PosX - 6, PosY + 80);     // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, PosX - 4, PosY - 18, 18, 18); // Kopf
                g.FillEllipse(myBrush, PosX - 4, PosY - 18, 18, 18);
                return true;
            }
            else if (schritte == 6)
            {
                Point[] points = new Point[14];
                points[0] = new Point(PosX + 12, PosY + 26);     //linke Hand
                points[1] = new Point(PosX + 4, PosY + 14);      // linker Ellenbogen
                points[2] = new Point(PosX, PosY);               // Oberkörper mitte
                points[3] = new Point(PosX - 4, PosY + 14);      // rechter Ellenbogen
                points[4] = new Point(PosX - 10, PosY + 32);     // rechte Hand
                points[5] = points[3];
                points[6] = points[2];
                points[7] = new Point(PosX - 2, PosY + 40);      // Hüfte
                points[8] = new Point(PosX + 4, PosY + 56);      // linkes Knie
                points[9] = new Point(PosX + 10, PosY + 78);     // linker Fuß
                points[10] = points[8];
                points[11] = points[7];
                points[12] = new Point(PosX - 4, PosY + 60);     // rechtes Knie
                points[13] = new Point(PosX - 10, PosY + 80);    // rechter Fuß
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, PosX - 4, PosY - 18, 18, 18); // Kopf
                g.FillEllipse(myBrush, PosX - 4, PosY - 18, 18, 18);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
