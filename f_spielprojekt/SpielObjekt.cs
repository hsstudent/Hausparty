using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace F_Spielprojekt
{
    public abstract class SpielObjekt
    {
        protected Panel meinBild;              // Jedes Spielobjekt hat ein Bild
        protected Pen pen;

        public SpielObjekt(Pen pen)
        {
            this.pen = pen;
        }

        public Panel MeinBild
        {
            get { return meinBild; }
            set { meinBild = value; }
        }
                
        public Pen Pen
        {
            get { return pen; }
        }
    }
}
