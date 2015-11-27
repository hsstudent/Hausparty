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
    public partial class Form1 : Form
    {
        private List<Personen> personen = new List<Personen>(); //Liste für den Hauptweg
        private bool i1 = true;                                 //Wegpunkgt gesetzt
        private bool i2 = true;
        private bool i3 = true;
        private bool i4 = true;
        private bool i5 = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bOptionen.Hide();                                  //Buttons ausblenden
            bHighscore.Hide();
            bStart.Hide();
            pB1.Enabled = true;
            pB2.Enabled = true;
            pB3.Enabled = true;
            pB4.Enabled = true;
            pB5.Enabled = true;

            Timer Timer1 = new Timer();                        //Timer initialisieren
            Timer1.Interval = 1000;                            //Timer Intervall festlegen
            Timer1.Start();                                    
            Timer1.Tick += new EventHandler(OnTickEvent);

        }

        private void OnTickEvent(Object myObject, EventArgs myEventArgs)
        {

        }

        private void pB1_Click(object sender, EventArgs e)
        {
            if (i1 == true)
            {
                pB1.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i1 = false;
            }
            else if (i1 == false)
            {
                pB1.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i1 = true;
            }
        }

        private void pB2_Click(object sender, EventArgs e)
        {
            if (i2 == true)
            {
                pB2.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i2 = false;
            }
            else if (i2 == false)
            {
                pB2.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i2 = true;
            }
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            if (i3 == true)
            {
                pB3.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i3 = false;
            }
            else if (i3 == false)
            {
                pB3.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i3 = true;
            }
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            if (i4 == true)
            {
                pB4.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i4 = false;
            }
            else if (i4 == false)
            {
                pB4.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i4 = true;
            }
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            if (i5 == true)
            {
                pB5.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i5 = false;
            }
            else if (i5 == false)
            {
                pB5.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i5 = true;
            }
        }

        private void bHighscore_Click(object sender, EventArgs e)
        {

        }

        private void bOptionen_Click(object sender, EventArgs e)
        {

        }
    }
}
