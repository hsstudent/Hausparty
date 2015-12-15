using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F_Spielprojekt
{
    public partial class Optionen : Form
    {
        private int lvl;
        public Optionen()
        {
            InitializeComponent();
        }

        public int Lvl
        { get { return lvl; } }

        private void rbLeicht_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLeicht.Checked)
            {
                lvl = 3; ;
            }
        }

        private void rbMittel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMittel.Checked)
            {
                lvl = 4;
            }
        }

        private void rbSchwer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSchwer.Checked)
            {
                lvl = 5;
            }
        }

        private void bSpeichern_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
