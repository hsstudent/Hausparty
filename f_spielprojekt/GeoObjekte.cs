using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace F_Spielprojekt
{
    public abstract class GeoObjekte : IDrawable
    {
        protected Punkt meinePosition;               // Y Punkt der Objekte

        public Punkt MeinePosition
        {
            get { return this.meinePosition; }
            set { this.meinePosition = value; }
        }

        public GeoObjekte(Punkt meinPunkt)
        {
            this.meinePosition = meinPunkt;
        }
        public abstract void Zeichne(Pen pen, Graphics g);
    }
}
