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
        protected Position meinePosition;
        private PictureBox meinBild;
        protected Form1 meineForm;

        public SpielObjekt(Position meinePosition, Farbe farbe, Form1 meineForm)
        {
            this.farbe = farbe;
            this.meinePosition = meinePosition;
            this.meineForm = meineForm;
        }

        public Farbe Farbe
        {
            get{ return farbe; }
        }

        public Position MeinePosition
        {
            get
            {
                return meinePosition;
            }
        }

        public PictureBox MeinBild
        {
            get
            {
                return meinBild;
            }

            set
            {
                meinBild = value;
            }
        }
    }
}
