using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace F_Spielprojekt
{

    public class Highscore                      //Erster Entwurf für permanente Speicherung von Highscore
    {
        private int score;
        private int highscore;
        private string spielerName;
        private string spielerNameHighscore;


        public Highscore()
        {
        }

        public Highscore(int start, string spieler)
        {
            this.score = start;
            this.spielerName = spieler;
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
        public int Hscore
        {
            get { return this.highscore; }
        }

        public string SpielerName
        {
            set { this.spielerName = value; }
        }
        public string SpielerNameHighscore
        {
            get { return this.spielerNameHighscore; }
        }

        public void Vergleich()
        {
            Laden();
            if (score > highscore)
            {
                MessageBox.Show("New Highscore!");
                Speichern();
            }
        }
        /// <summary>
        /// Speichert den Highscore in eine Binärdatei
        /// </summary>
        public void Speichern()
        {
            FileStream stream = File.Open("score", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(stream);
            bw.Write(spielerName);
            bw.Write(score);
            bw.Close();
        }
        /// <summary>
        /// Liest den Highscore aus
        /// </summary>
        public void Laden()
        {
            String pfad = "score";
            FileStream stream = File.Open(pfad, FileMode.OpenOrCreate);

            BinaryReader br = new BinaryReader(stream);

            while (br.PeekChar() != -1)
            {
                spielerNameHighscore = br.ReadString();
                highscore = br.ReadInt32();
                //break;
            }
            br.Close();
        }
        

    }
}
