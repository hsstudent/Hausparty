using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class Personen : SpielObjekte
    {
        public Personen(int farbe, int posX, int posY)
            : base (farbe, posX, posY)
        {
        }
    
        /*public void Laufen()
        {
            if(Person == ListeX)
            {
                PosX += 1;
            }
            else if (Person == ListeY)
            {
                PosY += 1;
            }

        }*/

    }
}
