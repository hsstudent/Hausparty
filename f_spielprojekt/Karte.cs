using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class Karte
    {
        public static int bewGenauigkeit = 30;
        List<Strecke> strecken = new List<Strecke>();
        private List<Figur> figuren = new List<Figur>();
        private Form1 form;

        public Karte(Form1 form)
        {
            this.form = form;

            Strecke strecke1 = new Strecke(Punkt.StartPosition, Punkt.Weiche1);
            strecke1.PB = form.PB1;
            strecken.Add(strecke1);
            Strecke strecke2 = new Strecke(Punkt.Weiche1, Punkt.Weiche2);
            strecke2.PB = form.PB2;
            strecken.Add(strecke2);
            Strecke strecke3 = new Strecke(Punkt.Weiche2, Punkt.Weiche3);
            strecke3.PB = form.PB3;
            strecken.Add(strecke3);
            Strecke strecke4 = new Strecke(Punkt.Weiche3, Punkt.Weiche4);
            strecke4.PB = form.PB4;
            strecken.Add(strecke4);
            Strecke strecke5 = new Strecke(Punkt.Weiche4, Punkt.Weiche5);
            strecke5.PB = form.PB5;
            strecken.Add(strecke5);
            Strecke strecke6 = new Strecke(Punkt.Weiche5, Punkt.EndPosition);
            strecke6.PB = form.PBPerson;
            strecken.Add(strecke6);

            Strecke strecke7 = new Strecke(Punkt.Weiche1, Punkt.haus1);
            strecke7.PB = form.PBPerson;
            strecken.Add(strecke7);
            Strecke strecke8 = new Strecke(Punkt.Weiche2, Punkt.haus2);
            strecke8.PB = form.PBPerson;
            strecken.Add(strecke8);
            Strecke strecke9 = new Strecke(Punkt.Weiche3, Punkt.haus3);
            strecke9.PB = form.PBPerson;
            strecken.Add(strecke9);
            Strecke strecke10 = new Strecke(Punkt.Weiche4, Punkt.haus4);
            strecke10.PB = form.PBPerson;
            strecken.Add(strecke10);
            Strecke strecke11 = new Strecke(Punkt.Weiche5, Punkt.haus5);
            strecke11.PB = form.PBPerson;
            strecken.Add(strecke11);
        }

        public List<Figur> Figuren
        {
            get
            {
                return figuren;
            }

            set
            {
                figuren = value;
            }
        }

        public void streckeAendern()
        {
            for(int i = 0; i < figuren.Count; i++)
            {
                if(figuren[i].laufeStrecke())
                {

                }
                else
                {
                    foreach (Strecke strecke in strecken)
                    {
                        if (figuren[i].MeineStrecke.PB.Wegpunkt && strecke.Punkte[0] == figuren[i].MeineStrecke.Punkte[1])
                        {
                            figuren[i].MeineStrecke = strecke;
                        }
                        else if (strecke.Punkte[0] == figuren[i].MeineStrecke.Punkte[1])
                        {
                            figuren[i].MeineStrecke = strecke;
                        }
                        else
                        {
                            figuren.RemoveAt(i);
                        }
                    }
                }
            }
        }

        public void addFigur(Figur figur)
        {
            Figuren.Add(figur);
        }
    }
}
