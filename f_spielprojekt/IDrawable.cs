using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace F_Spielprojekt
{
    interface IDrawable
    {
        void Zeichne(Pen pen, Graphics g);
    }
}
