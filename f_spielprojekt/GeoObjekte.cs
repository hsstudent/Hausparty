using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace F_Spielprojekt
{
    public abstract class GeoObjekte : IDrawable
    {
        protected Punkt meinPunkt;               // Y Punkt der Objekte

        public Punkt MeinPunkt
        {
            get { return this.meinPunkt; }
            set { this.meinPunkt = value; }
        }

        public GeoObjekte(Punkt meinPunkt)
        {
            this.meinPunkt = meinPunkt;
        }
        public abstract void Zeichne(Pen pen, Graphics g);
    }
}
