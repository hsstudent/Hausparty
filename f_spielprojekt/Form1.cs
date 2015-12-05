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

        Karte meineKarte;                                   // Die Karte beinhaltet die Strecken

        int punkte = 0;                                     // TODO: Punkte muss den Spielern zugeordnet werden

        Timer Timer1;

        private int zaehler = 1;                            // Nach jedem 10 Interval, soll ein neues Männchen genertiert werden

        public int Punkte
        {
            get
            {
                return punkte;
            }

            set
            {
                punkte = value;
            }
        }

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

            Timer1 = new Timer();                               // Timer initialisieren
            Timer1.Interval = 1000;                             // Timer Intervall festlegen
            Timer1.Start();                
            Timer1.Tick += new EventHandler(OnTickEvent);
            

            meineKarte = new Karte(this);

            // Häuser erstellen und Farbe zuweisen
            Haus haus1 = new Haus(Farbe.Blau);
            Haus haus2 = new Haus(Farbe.Gelb);
            Haus haus3 = new Haus(Farbe.Grün);
            Haus haus4 = new Haus(Farbe.Rot);
            Haus haus5 = new Haus(Farbe.Schwarz);

            // Die Strecken bekommen Häuser
            meineKarte.Strecken[6].Haus = haus1;
            meineKarte.Strecken[7].Haus = haus2;
            meineKarte.Strecken[8].Haus = haus3;
            meineKarte.Strecken[9].Haus = haus4;
            meineKarte.Strecken[10].Haus = haus5;

            neueFigur();                                        //Anfangsmännchen
        }

        private void OnTickEvent(Object myObject, EventArgs myEventArgs)
        {
            zaehler++;

            // Wenn der Timer abläuft, soll die Karte die Strecke ändern
            meineKarte.streckeAendern();

            if (zaehler == 10)
            {
                // Nach jeder 10ten Streckänderung soll eine Figur erstellt werden
                neueFigur();
            }
        }

        private void neueFigur()
        {
            zaehler = 1;
            Figur meinePerson = new Figur(zufallsFarbe(), meineKarte);
            meineKarte.addFigur(meinePerson);
            meinePerson.MeineStrecke = meineKarte.Strecken[0];

            pBPerson = new PictureBox1();
            meinePerson.MeinBild = pBPerson;    // Die Figur erhält ein Bild auf dem Form


            // Hier stehen die Bildeinstellung der Figur
            ((ISupportInitialize)(pBPerson)).BeginInit();
            this.SuspendLayout();

            pBPerson.Enabled = false;
            pBPerson.Image = Properties.Resources.StraßeGeradeButton;
            pBPerson.Margin = new Padding(2);
            pBPerson.Location = new Point(Punkt.StartPosition.X, Punkt.StartPosition.Y);
            pBPerson.Name = "pBPerson" + meineKarte.Figuren.Count.ToString();
            pBPerson.Size = new Size(34, 41);
            pBPerson.SizeMode = PictureBoxSizeMode.StretchImage;

            Controls.Add(pBPerson); // Das Bild wird dem Form zugewiesen

            ((System.ComponentModel.ISupportInitialize)(this.pBPerson)).EndInit();
            this.ResumeLayout(false);
        }

        // Zufallsfarben
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

        // Hier werden die Weichen behandelt
        private void pB1_Click(object sender, EventArgs e)
        {
            if (!pB1.Wegpunkt)
            {
                pB1.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                pB1.Wegpunkt = true;
            }
            else
            {
                pB1.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                pB1.Wegpunkt = false;
            }
        }

        private void pB2_Click(object sender, EventArgs e)
        {
            if (!pB2.Wegpunkt)
            {
                pB2.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                pB2.Wegpunkt = true;
            }
            else
            {
                pB2.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                pB2.Wegpunkt = false;
            }
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            if (!pB3.Wegpunkt)
            {
                pB3.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                pB3.Wegpunkt = true;
            }
            else 
            {
                pB3.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                pB3.Wegpunkt = false;
            }
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            if (!pB4.Wegpunkt)
            {
                pB4.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                pB4.Wegpunkt = true;
            }
            else
            {
                pB4.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                pB4.Wegpunkt = false;
            }
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            if (!pB5.Wegpunkt)
            {
                pB5.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                pB5.Wegpunkt = true;
            }
            else 
            {
                pB5.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                pB5.Wegpunkt = false;
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
            #if Debug
            MessageBox.Show(e.X.ToString()+ " " + e.Y.ToString());
            #endif
        }
    }
}
