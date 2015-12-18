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
        protected Pen pen;
        protected Panel meinPanel;

        public SpielObjekt(Pen pen)
        {
            this.pen = pen;
        }
                
        public Pen Pen
        {
            get { return pen; }
        }

        public Panel MeinPanel
        {
            get
            {
                return meinPanel;
            }

            set
            {
                meinPanel = value;
            }
        }
    }
}
