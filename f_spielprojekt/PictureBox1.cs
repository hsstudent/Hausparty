using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class PictureBox1 : System.Windows.Forms.PictureBox
    {
        private bool wegpunkt = false;  // Die PictureBox speichert, ob der Wegpunkt gesetzt ist oder nicht

        public bool Wegpunkt
        {
            get { return wegpunkt; }
            set { wegpunkt = value; }
        }
    }
}
