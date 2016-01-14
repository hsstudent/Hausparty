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
        /// <summary>
        /// Zeichnet die Männchen relativ zur Form in einer Box
        /// Die Bewegung des Männchens hat x unterschiedliche Positionen, die eine Bewegung simulieren.
        /// </summary>
        /// <param name="schritte"></param>
        public void Zeichne(int schritte)       // Zeichnet die Stickmans
        {
            schritte = (schritte % 6);

            if (schritte == 0)                                                           // Schritt ist für die animation zuständig (1 - 6)
            {
                Point[] points = 
                {
                    new Point(meinPunkt.X - 6, meinPunkt.Y + 15),     //linke Hand
                    new Point(meinPunkt.X - 4, meinPunkt.Y + 8),      // linker Ellenbogen
                    new Point(meinPunkt.X, meinPunkt.Y),               // Oberkörper mitte
                    new Point(meinPunkt.X + 4, meinPunkt.Y + 8),      // rechter Ellenbogen
                    new Point(meinPunkt.X + 9, meinPunkt.Y + 11),     // rechte Hand
                    new Point(meinPunkt.X + 4, meinPunkt.Y + 8),
                    new Point(meinPunkt.X, meinPunkt.Y),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),      // Hüfte
                    new Point(meinPunkt.X - 3, meinPunkt.Y + 30),      // linkes Knie
                    new Point(meinPunkt.X - 7, meinPunkt.Y + 40),     // linker Fuß
                    new Point(meinPunkt.X - 3, meinPunkt.Y + 30),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),
                    new Point(meinPunkt.X + 3, meinPunkt.Y + 30),     // rechtes Knie
                    new Point(meinPunkt.X + 5, meinPunkt.Y + 40),    // rechter Fuß
                };
                
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9);
            }
            else if (schritte == 1)
            {
                Point[] points = 
                {
                    new Point(meinPunkt.X - 3, meinPunkt.Y + 16),      //linke Hand
                    new Point(meinPunkt.X - 2, meinPunkt.Y + 7),      // linker Ellenbogen
                    new Point(meinPunkt.X, meinPunkt.Y),               // Oberkörper mitte
                    new Point(meinPunkt.X + 4, meinPunkt.Y + 7),      // rechter Ellenbogen
                    new Point(meinPunkt.X + 5, meinPunkt.Y + 13),     // rechte Hand
                    new Point(meinPunkt.X + 4, meinPunkt.Y + 7),
                    new Point(meinPunkt.X, meinPunkt.Y),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),      // Hüfte
                    new Point(meinPunkt.X - 2, meinPunkt.Y + 29),      // linkes Knie
                    new Point(meinPunkt.X - 7, meinPunkt.Y + 38),     // linker Fuß
                    new Point(meinPunkt.X - 2, meinPunkt.Y + 29),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),
                    new Point(meinPunkt.X + 2, meinPunkt.Y + 30),     // rechtes Knie
                    new Point(meinPunkt.X + 3, meinPunkt.Y + 40),     // rechter Fuß
                };
                
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 3, meinPunkt.Y - 10, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 3, meinPunkt.Y - 10, 9, 9);
            }
            else if (schritte == 2)
            {
                Point[] points = 
                {
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 17),      //linke Hand
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 7),     // linker Ellenbogen
                    new Point(meinPunkt.X, meinPunkt.Y),               // Oberkörper mitte
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 7),     // rechter Ellenbogen
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 15),     // rechte Hand
                    new Point(meinPunkt.X, meinPunkt.Y),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 7),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),      // Hüfte
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 29),      // linkes Knie
                    new Point(meinPunkt.X - 6, meinPunkt.Y + 36),     // linker Fuß
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 29),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),                                        
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 30),     // rechtes Knie
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 40),     // rechter Fuß
                };
                
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 3, meinPunkt.Y - 10, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 3, meinPunkt.Y - 10, 9, 9);
            }
            else if (schritte == 3)
            {
                Point[] points = 
                {
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 17),     //linke Hand
                    new Point(meinPunkt.X, meinPunkt.Y + 7),         // linker Ellenbogen
                    new Point(meinPunkt.X, meinPunkt.Y),             // Oberkörper mitte
                    new Point(meinPunkt.X, meinPunkt.Y + 7),         // rechter Ellenbogen
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 17),     // rechte Hand
                    new Point(meinPunkt.X, meinPunkt.Y + 7),
                    new Point(meinPunkt.X, meinPunkt.Y),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),      // Hüfte
                    new Point(meinPunkt.X, meinPunkt.Y + 28),          // linkes Knie
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 37),      // linker Fuß
                    new Point(meinPunkt.X, meinPunkt.Y + 28),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),
                    new Point(meinPunkt.X, meinPunkt.Y + 30),         // rechtes Knie
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 40),     // rechter Fuß
                };
                
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9);
            }
            else if (schritte == 4)
            {
                Point[] points = 
                {
                    new Point(meinPunkt.X + 3, meinPunkt.Y + 15),      //linke Hand
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 7),      // linker Ellenbogen
                    new Point(meinPunkt.X, meinPunkt.Y),               // Oberkörper mitte
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 7),      // rechter Ellenbogen
                    new Point(meinPunkt.X - 3, meinPunkt.Y + 17),      // rechte Hand
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 7),
                    new Point(meinPunkt.X, meinPunkt.Y),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),      // Hüfte
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 28),      // linkes Knie
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 38),      // linker Fuß
                    new Point(meinPunkt.X + 1, meinPunkt.Y + 28),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 30),     // rechtes Knie
                    new Point(meinPunkt.X - 3, meinPunkt.Y + 40),    // rechter Fuß
                };
                
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9);
            }
            else if (schritte == 5)
            {
                Point[] points = 
                {
                    new Point(meinPunkt.X + 6, meinPunkt.Y + 13),     //linke Hand
                    new Point(meinPunkt.X + 2, meinPunkt.Y + 7),      // linker Ellenbogen
                    new Point(meinPunkt.X, meinPunkt.Y),              // Oberkörper mitte
                    new Point(meinPunkt.X - 2, meinPunkt.Y + 7),      // rechter Ellenbogen
                    new Point(meinPunkt.X - 5, meinPunkt.Y + 16),     // rechte Hand
                    new Point(meinPunkt.X - 2, meinPunkt.Y + 7),
                    new Point(meinPunkt.X, meinPunkt.Y),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),      // Hüfte
                    new Point(meinPunkt.X + 2, meinPunkt.Y + 28),      // linkes Knie
                    new Point(meinPunkt.X + 5, meinPunkt.Y + 38),     // linker Fuß
                    new Point(meinPunkt.X + 2, meinPunkt.Y + 28),
                    new Point(meinPunkt.X - 1, meinPunkt.Y + 20),
                    new Point(meinPunkt.X - 2, meinPunkt.Y + 30),     // rechtes Knie
                    new Point(meinPunkt.X - 5, meinPunkt.Y + 40),    // rechter Fuß
                };
                
                g.DrawLines(pen, points);
                g.DrawEllipse(pen, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9); // Kopf
                g.FillEllipse(myBrush, meinPunkt.X - 2, meinPunkt.Y - 9, 9, 9);
            }
        }
    }
}
