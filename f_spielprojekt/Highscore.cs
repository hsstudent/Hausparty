using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class Highscore                      //Erster Entwurf für permanente Speicherung von Highscore
    {
        private int score;
        private string spielerName;

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



    }
}
