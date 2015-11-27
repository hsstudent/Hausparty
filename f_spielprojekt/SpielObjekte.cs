using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public abstract class SpielObjekte
    {
        protected int farbe;
        protected int posX;
        protected int posY;

        public SpielObjekte(int farbe, int posX, int posY)
        {
            this.farbe = farbe;
            this.posX = posX;
            this.posY = posY;
        }

        public int Farbe
        {
            get{ return farbe; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get{ return posY; }
            set { posY = value; }
        }
    }
}
