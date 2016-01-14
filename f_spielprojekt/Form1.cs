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
        int lvl = 4;                                        // Schwierigkeitsstufe 4/5/6 für spätere implementierung
        Karte meineKarte;                                   // Die Karte beinhaltet die Strecken
        int punkte = 0;                                     // Punktezähler im Spiel
        int leben = 3;
        Highscore neu = new Highscore();  // Name für das Highscore eintragen                                    // Instanz für einen Spieler angelegt
        Timer timer;
        Timer v;                                            // Geschwindigkeit
        private int zaehler = 0;                            // Nach jedem 10 Interval, soll ein neues Männchen genertiert werden
        float stiftbreite = 4f;

        
        public int Punkte
        {
            get { return punkte; }
            set { punkte = value; }
        }
        public int Leben
        {
            get { return leben; }
            set { leben = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Deaktiviert die Weichen und aktiviert die Menü Buttons.
        /// </summary>
        public void spielEnde()
        {
            bOptionen.Show();
            bHighscore.Show();
            bStart.Show();
            lSchwierigkeit.Visible = true;

            rtbName.Show();
            lName.Show();

            pB1.Enabled = false;
            pB2.Enabled = false;
            pB3.Enabled = false;
            pB4.Enabled = false;
            pB5.Enabled = false;

            

            timer.Stop();
            neu.Score = punkte;
            neu.Vergleich();
        }
        /// <summary>
        /// Die einzelnen Strecken bekommen Häuser zugewiesen.
        /// Aktiviert das Spiel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bStart_Click(object sender, EventArgs e)
        {
            bOptionen.Hide();                                   // Buttons ausblenden
            bHighscore.Hide();
            bStart.Hide();
            rtbName.Hide();
            lName.Hide();
            lScore.Visible = true;
            lLeben.Visible = true;
            punkte = 0;
            leben = 3;
            HighscoreAktualisieren();
            LebenAktualisieren();
            neu.SpielerName = rtbName.Text;
            lSchwierigkeit.Visible = false;
            

            pB1.Enabled = true;                                 // Wegbuttons aktivieren
            pB2.Enabled = true;
            pB3.Enabled = true;
            pB4.Enabled = true;
            pB5.Enabled = true;

            timer = new Timer();                               // Timer initialisieren
            timer.Interval = 100;                              // Timer Intervall festlegen
            timer.Start();                
            timer.Tick += new EventHandler(OnTickEvent);

            meineKarte = new Karte(this);

            // Häuser erstellen und Farbe zuweisen
            Haus haus1 = new Haus(new Pen(Color.Yellow));
            Haus haus2 = new Haus(new Pen(Color.Blue));
            Haus haus3 = new Haus(new Pen(Color.Green));
            Haus haus4 = new Haus(new Pen(Color.Red));
            Haus haus5 = new Haus(new Pen(Color.Black));

            // Die Strecken bekommen Häuser
            meineKarte.Strecken[1].Haus = haus1;
            meineKarte.Strecken[3].Haus = haus2;
            meineKarte.Strecken[5].Haus = haus3;
            meineKarte.Strecken[7].Haus = haus4;
            meineKarte.Strecken[9].Haus = haus5;

            neueFigur();                                        //Anfangsmännchen
        }
        /// <summary>
        /// Wenn der Timer abgelaufen ist, sollen alle Figuren einen Schritt weiter laufen.
        /// Nach einer bestimmten Zahl i, soll ein Männchen erzeugt werden und die Geschwindigkeit erhöht werden.
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        private void OnTickEvent(Object myObject, EventArgs myEventArgs)
        {
            zaehler++;

            // Wenn der Timer abläuft, soll die Karte die Strecke ändern
            meineKarte.streckeAendern();

            if (zaehler == 50)
            {
                // Nach jeder 50ten Streckänderung soll eine Figur erstellt werden  // Genauigkeit beeinflust diesen Wert
                neueFigur();
                if(timer.Interval < 1)
                {
                    spielEnde();
                }
                timer.Interval--;
            }
            System.Threading.Thread.Sleep(timer.Interval);
        }

        /// <summary>
        /// Eine neue Figur wird gezeichnet und der Form übergeben
        /// Die Figur erhählt eine Strecke und eine Startposition
        /// </summary>
        private void neueFigur()
        {
            Panel panel = new Panel();
            panel.Enabled = false;
            panel.BackColor = Color.Transparent;
            panel.Location = new Point(Punkt.StartPosition.X, Punkt.StartPosition.Y);
            panel.Size = new Size(30, 80);
            Controls.Add(panel);
            zaehler = 0;

            Random rndFarbe = new Random();
            int farbe = rndFarbe.Next(1, lvl);
            Pen pen = new Pen(Color.Transparent);
            SolidBrush myBrush = new SolidBrush(Color.Transparent);
            switch(farbe)
            {
                case 1: pen = new Pen(Color.Black, stiftbreite);
                        myBrush = new SolidBrush(Color.Black); break;
                case 2: pen = new Pen(Color.Red, stiftbreite);
                        myBrush = new SolidBrush(Color.Red);break;
                case 3: pen = new Pen(Color.Green, stiftbreite);
                        myBrush = new SolidBrush(Color.Green);break;
                case 4: pen = new Pen(Color.Blue, stiftbreite);
                        myBrush = new SolidBrush(Color.Blue);break;
                case 5: pen = new Pen(Color.Yellow, stiftbreite);
                        myBrush = new SolidBrush(Color.Yellow);break;
            }
            Graphics g = panel.CreateGraphics();
            Stickman stickman = new Stickman(new Punkt(10, 25), 1, myBrush, pen, g);
            Figur meineFigur = new Figur(pen, meineKarte, stickman);
            meineFigur.MeinPanel = panel;
            meineKarte.addFigur(meineFigur);
            meineFigur.MeineStrecke = meineKarte.Strecken[0];
            stickman.Zeichne(1);
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

        private void bHighscore_Click(object sender, EventArgs e)           //unvollständig
        {
            neu.Laden();
            MessageBox.Show("Spieler: " + neu.SpielerNameHighscore + " Highscore: " + neu.Hscore);
        }
        
        private void bOptionen_Click(object sender, EventArgs e)        
        {
            Optionen form2 = new Optionen();
            form2.ShowDialog();
            lvl = form2.Lvl;
            SchwierigkeitAktualisieren();
        }

        private void Form1_Click(object sender, MouseEventArgs e)
        {
            
            //MessageBox.Show(e.X.ToString()+ " " + e.Y.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtbName_TextChanged(object sender, EventArgs e)
        {
            if (rtbName.Text != "")
            {
                bStart.Enabled = true;
            }
            else
            { bStart.Enabled = false; }
        }

        public void HighscoreAktualisieren()                        //Aktualisiert die Punkteanzeige während dem Spiel
        {
            lScore.Text = "Score: " + punkte;
        }
        public void LebenAktualisieren()                        //Aktualisiert die Lebenanzeige während dem Spiel
        {
            lLeben.Text = "Leben: " + leben;
            if (leben <= 1)
            {
                lLeben.ForeColor = Color.Red;
            }
            else
            {
                lLeben.ForeColor = Color.Black;
            }
        }

        public void SchwierigkeitAktualisieren()
        {
            if (lvl == 4)
            {
                lSchwierigkeit.Text = "Schwierigkeit: Leicht";
            }
            else if (lvl == 5)
            {
                lSchwierigkeit.Text = "Schwierigkeit: Mittel";
            }
            else
            {
                lSchwierigkeit.Text = "Schwierigkeit: Schwer";
            }
        }

        private void lLeben_Click(object sender, EventArgs e)
        {

        }

        private void lScore_Click(object sender, EventArgs e)
        {

        }

    }
}
