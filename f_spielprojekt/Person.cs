using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class Person : SpielObjekt
    {
        public Person(Position meinePosition, int farbe)
            : base (meinePosition, farbe)
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
