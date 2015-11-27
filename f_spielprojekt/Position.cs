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
        private static Position startPosition = new Position(50, 50);   // Startposition festlegen

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
    }
}
