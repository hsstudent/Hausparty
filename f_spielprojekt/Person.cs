using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F_Spielprojekt
{
    public class Person : SpielObjekt
    {
        public Person(Position meinePosition, Farbe farbe, Form1 meineForm)
            : base (meinePosition, farbe, meineForm)
        {
            PictureBox meinBild = new PictureBox();
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
