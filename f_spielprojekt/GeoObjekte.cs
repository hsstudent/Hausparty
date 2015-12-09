using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace F_Spielprojekt
{
    public abstract class GeoObjekte : IDrawable
    {
        protected int posX;                 // X Punkt der Objekte
        protected int posY;                 // Y Punkt der Objekte
        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }
        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }
        public GeoObjekte(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
        public abstract void Zeichne(Pen pen, Graphics g);
    }
}
