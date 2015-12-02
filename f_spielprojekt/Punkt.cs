using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class Punkt
    {
        private int x;
        private int y;

        //private delegate positionErreicht;
        //private event positionErreicht;

        private static Punkt startPosition = new Punkt(-25, 236);   // Startposition festlegen

        private static Punkt endPosition = new Punkt(780, 236);     // Endposition 

        private static Punkt weiche1 = new Punkt(150, 236);
        private static Punkt weiche2 = new Punkt(286, 236);
        private static Punkt weiche3 = new Punkt(422, 236);
        private static Punkt weiche4 = new Punkt(562, 236);
        private static Punkt weiche5 = new Punkt(699, 236);

        public static Punkt haus1 = new Punkt(150, 112);
        public static Punkt haus2 = new Punkt(286, 112);
        public static Punkt haus3 = new Punkt(422, 112);
        public static Punkt haus4 = new Punkt(562, 112);
        public static Punkt haus5 = new Punkt(699, 112);

        public Punkt(int posX, int posY)
        {
            this.x = posX;
            this.y = posY;
        }
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public static Punkt StartPosition
        {
            get
            {
                return startPosition;
            }
        }

        public static Punkt Weiche1
        {
            get
            {
                return weiche1;
            }
        }

        public static Punkt Weiche2
        {
            get
            {
                return weiche2;
            }
        }

        public static Punkt Weiche3
        {
            get
            {
                return weiche3;
            }
        }

        public static Punkt Weiche4
        {
            get
            {
                return weiche4;
            }
        }

        public static Punkt Weiche5
        {
            get
            {
                return weiche5;
            }
        }

        public static Punkt EndPosition
        {
            get
            {
                return endPosition;
            }

            set
            {
                endPosition = value;
            }
        }
    }
}
