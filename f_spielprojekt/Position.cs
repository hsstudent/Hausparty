using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class Position
    {
        private int posX;
        private int posY;

        //private delegate positionErreicht;
        //private event positionErreicht;

        private static Position startPosition = new Position(5, 236);   // Startposition festlegen
        private static Position endPosition = new Position(767, 236);     // Endposition 
        private static Position weiche1 = new Position(150, 236);
        private static Position weiche2 = new Position(286, 236);
        private static Position weiche3 = new Position(422, 236);
        private static Position weiche4 = new Position(562, 236);
        private static Position weiche5 = new Position(699, 236);

        public Position(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
        public int PosX
        {
            get
            {
                return posX;
            }

            set
            {
                posX = value;
            }
        }

        public int PosY
        {
            get
            {
                return posY;
            }

            set
            {
                posY = value;
            }
        }

        public static Position StartPosition
        {
            get
            {
                return startPosition;
            }
        }

        public static Position Weiche1
        {
            get
            {
                return weiche1;
            }
        }

        public static Position Weiche2
        {
            get
            {
                return weiche2;
            }
        }

        public static Position Weiche3
        {
            get
            {
                return weiche3;
            }
        }

        public static Position Weiche4
        {
            get
            {
                return weiche4;
            }
        }

        public static Position Weiche5
        {
            get
            {
                return weiche5;
            }
        }
    }
}
