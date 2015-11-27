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

        Timer Timer1;

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

            Timer1 = new Timer();                         // Timer initialisieren
            Timer1.Interval = 1000;                             // Timer Intervall festlegen
            Timer1.Start();                                       
            Timer1.Tick += new EventHandler(OnTickEvent);

        }

        private void OnTickEvent(Object myObject, EventArgs myEventArgs)
        {
            zaehler++;

            foreach (Person person in personen)
            {
                person.MeinBild.Location = new Point(person.MeinBild.Location.X+5, person.MeinBild.Location.Y); // Bild bewegen
            }

            if (zaehler == 10)
            {
                zaehler = 1;
                Person meinePerson = new Person(Position.StartPosition, zufallsFarbe(), this);
                personen.Add(meinePerson);

                pBPerson = new PictureBox();
                meinePerson.MeinBild = pBPerson;

                //
                // pBPerson
                //

                ((ISupportInitialize)(pBPerson)).BeginInit();
                this.SuspendLayout();

                pBPerson.Enabled = false;
                pBPerson.Image = Properties.Resources.StraßeGeradeButton;
                pBPerson.Margin = new Padding(2);
                pBPerson.Location = new Point(Position.StartPosition.PosX, Position.StartPosition.PosY);
                pBPerson.Name = "pBPerson" + personen.Count.ToString();
                pBPerson.Size = new Size(34, 41);
                pBPerson.SizeMode = PictureBoxSizeMode.StretchImage;

                Controls.Add(pBPerson);

                ((System.ComponentModel.ISupportInitialize)(this.pBPerson)).EndInit();
                this.ResumeLayout(false);

                Timer1.Interval--;
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
            if (i1)
            {
                pB1.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i1 = false;
            }
            else
            {
                pB1.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i1 = true;
            }
        }

        private void pB2_Click(object sender, EventArgs e)
        {
            if (i2)
            {
                pB2.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i2 = false;
            }
            else
            {
                pB2.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i2 = true;
            }
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            if (i3)
            {
                pB3.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i3 = false;
            }
            else 
            {
                pB3.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i3 = true;
            }
        }

        private void pB4_Click(object sender, EventArgs e)
        {
            if (i4)
            {
                pB4.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i4 = false;
            }
            else
            {
                pB4.Image = F_Spielprojekt.Properties.Resources.StraßeGeradeButton;
                i4 = true;
            }
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            if (i5)
            {
                pB5.Image = F_Spielprojekt.Properties.Resources.StraßeKurfeButton;
                i5 = false;
            }
            else 
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
