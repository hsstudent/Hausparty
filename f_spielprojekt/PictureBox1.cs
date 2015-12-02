using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class PictureBox1 : System.Windows.Forms.PictureBox
    {
        private bool wegpunkt = false;

        public bool Wegpunkt
        {
            get
            {
                return wegpunkt;
            }

            set
            {
                wegpunkt = value;
            }
        }
    }
}
