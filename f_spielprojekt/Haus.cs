using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class Haus : SpielObjekt
    {

        public Haus(Position meinePosition, Farbe farbe, Form1 meineForm) : base (meinePosition, farbe, meineForm)
        {

        }
        /*private int wegzumhaus;

        public event EventHandler Haus_Arrived;

        public Haeuser()
        {
            throw new System.NotImplementedException();
        }

        public void LaufezumHaus()
        {
            throw new System.NotImplementedException();
        }*/
    }
}
