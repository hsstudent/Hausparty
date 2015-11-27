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
        private List<Person> personen = new List<Person>(); // Liste für den Hauptweg
        private bool i1 = true;                                 // Wegpunkgt gesetzt
        private bool i2 = true;
        private bool i3 = true;
        private bool i4 = true;
        private bool i5 = true;

        private int zaehler = 1;                                    // Nach jedem 10 Interval, soll ein neues Männchen genertiert werden
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bOptionen.Hide();                                   // Buttons ausblenden
            bHighscore.Hide();
            bStart.Hide();

            pB1.Enabled = true;                                 // Wegbuttons aktivieren
            pB2.Enabled = true;
            pB3.Enabled = true;
            pB4.Enabled = true;
            pB5.Enabled = true;

            Timer Timer1 = new Timer();                         // Timer initialisieren
            Timer1.Interval = 1000;                             // Timer Intervall festlegen
            Timer1.Start();                                       
            Timer1.Tick += new EventHandler(OnTickEvent);

        }

        private void OnTickEvent(Object myObject, EventArgs myEventArgs)
        {
            zaehler++;

            foreach (Person person in personen)
            {
                person.MeinePosition.PosX += 10;
            }
            if (zaehler == 10)
            {
                Person meinePerson = new Person(Position.StartPosition, zufallsFarbe(), this);
                pBPerson = new PictureBox();
                //
                // pBPerson
                //
                pBPerson.Enabled = false;
                pBPerson.Image = ((System.Drawing.Image)(resources.GetObject("pB5.Image")));
                pBPerson.Margin = new System.Windows.Forms.Padding(2);
                pBPerson.Location = new System.Drawing.Point(Position.StartPosition.PosX, Position.StartPosition.PosY);
                pBPerson.Name = "pBPerson" + personen.Count.ToString();
                pBPerson.Size = new System.Drawing.Size(34, 41);
                pBPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                meinePerson.MeinBild = pBPerson;
                personen.Add(meinePerson);
            }
        }

        private Farbe zufallsFarbe()
        {
            int zufallsZahl;
            Random rdm = new Random();
            zufallsZahl = rdm.Next(0, 5);
            switch (zufallsZahl)
            {
                case 0: return Farbe.Blau;
                case 1: return Farbe.Gelb;
                case 2: return Farbe.Grün;
                case 3: return Farbe.Rot;
                case 4: return Farbe.Schwarz;
                default: return Farbe.Schwarz;
            }
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

        private void Form1_Click(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString()+ " " + e.Y.ToString());
        }
    }
}
