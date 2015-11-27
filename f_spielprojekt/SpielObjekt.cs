using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public abstract class SpielObjekt
    {
        protected int farbe;
        protected Position meinePosition;

        public SpielObjekt(Position meinePosition, int farbe)
        {
            this.farbe = farbe;
            this.meinePosition = meinePosition;
        }

        public int Farbe
        {
            get{ return farbe; }
        }
    }
}
