using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F_Spielprojekt
{
    public abstract class SpielObjekt
    {
        protected Farbe farbe;  
        protected Form meinBild;              // Jedes Spielobjekt hat ein Bild

        public SpielObjekt(Farbe farbe)
        {
            this.farbe = farbe;
        }

        public Farbe Farbe
        {
            get { return farbe; }
        }

        public Form MeinBild
        {
            get { return meinBild; }
            set { meinBild = value; }
        }
    }
}
