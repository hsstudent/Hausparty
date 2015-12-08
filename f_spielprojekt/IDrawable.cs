using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Stickman
{
    interface IDrawable
    {
        void Zeichne(Pen pen, Graphics g);
    }
}
