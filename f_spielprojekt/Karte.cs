using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_Spielprojekt
{
    public class Karte
    {
        public static int bewGenauigkeit = 100;                                     // Gibt an, ob jeder Pixel abgelaufen werden soll, oder nur ein Teil der Pixel
        List<Strecke> strecken = new List<Strecke>();                               // Die Liste der Strecken für die Karte
        private List<Figur> figuren = new List<Figur>();                            // Die Liste der Figuren für die Karte
        private Form1 form;                                                         // Gibt an auf welchem Form die Karte liegen soll

        public Karte(Form1 form)                                                    // Erzeug die Karte mit allen Stecken, Weichen
        {
            this.form = form;
            
            Strecke strecke1 = new Strecke(Punkt.StartPosition, Punkt.Weiche1);     // Die Karte erhält die einzelnen Strecken
            strecken.Add(strecke1);
            Strecke strecke7 = new Strecke(Punkt.Weiche1, Punkt.haus1);
            strecken.Add(strecke7);
            Strecke strecke2 = new Strecke(Punkt.Weiche1, Punkt.Weiche2);
            strecken.Add(strecke2);
            Strecke strecke8 = new Strecke(Punkt.Weiche2, Punkt.haus2);
            strecken.Add(strecke8);
            Strecke strecke3 = new Strecke(Punkt.Weiche2, Punkt.Weiche3);
            strecken.Add(strecke3);
            Strecke strecke9 = new Strecke(Punkt.Weiche3, Punkt.haus3);
            strecken.Add(strecke9);
            Strecke strecke4 = new Strecke(Punkt.Weiche3, Punkt.Weiche4);
            strecken.Add(strecke4);
            Strecke strecke10 = new Strecke(Punkt.Weiche4, Punkt.haus4);
            strecken.Add(strecke10);
            Strecke strecke5 = new Strecke(Punkt.Weiche4, Punkt.Weiche5);
            strecken.Add(strecke5);
            Strecke strecke11 = new Strecke(Punkt.Weiche5, Punkt.haus5);
            strecken.Add(strecke11);
            Strecke strecke6 = new Strecke(Punkt.Weiche5, Punkt.EndPosition);
            strecken.Add(strecke6);
           
            strecke7.PB = form.PB1;                                                 // Die Karte erhalten die einzelnen Weichen
            strecke8.PB = form.PB2;
            strecke9.PB = form.PB3;
            strecke10.PB = form.PB4;
            strecke11.PB = form.PB5;
        }

        public List<Figur> Figuren
        {
            get { return figuren; }
            set { figuren = value; }
        }

        public List<Strecke> Strecken
        {
            get { return strecken; }
            set { strecken = value; }
        }

        public void streckeAendern()                                                // Alle Figuren laufen einen Schritt weiter
        {
            for(int i = 0; i < figuren.Count; i++)
            {               
                if(figuren[i].laufeStrecke())                                     // Die Figuren laufen der Strecke entlang bis zum Ende.
                {
                }
                else                                                                // Ist die Strecke zu Ende, wird die Figur gelöscht oder zur nächsten Stecke geschickt
                {
                    for (int j = 0; j < strecken.Count; j++)
                    {                        
                        if (strecken[j].PB != null)                                 // Strecke und Wegpunkt überprüfen
                        { 
                            if (strecken[j].PB.Wegpunkt && figuren[i].MeineStrecke.Punkte[1] == strecken[j].Punkte[0])
                            {
                                figuren[i].MeineStrecke = strecken[j];
                                figuren[i].Schritt = 0;
                                figuren[i].laufeStrecke();
                                break;
                            }
                        }                        
                        else if (strecken[j].Punkte[0] == figuren[i].MeineStrecke.Punkte[1])    // Strecke ohne Wegpunkt
                        {
                            figuren[i].MeineStrecke = strecken[j];
                            figuren[i].Schritt = 0;
                            figuren[i].laufeStrecke();
                            break;
                        }     
                        else if(j+1 == strecken.Count)                              // Ende der Strecke
                        { 
                            if(strecken[j].Haus.Pen.Color == figuren[i].Stickman.Pen.Color)          // Farbe überprüfen
                            {    
                                form.Punkte++;                                      // Farbe passt +1 Punkt
                            }
                            else
                            {
                                form.Punkte--;                                      // Farbe falsch -1 Punkt                         
                            }
                            figuren.RemoveAt(i);
                        }    
                    }
                }
            }
        }


        public void addFigur(Figur figur)                                           // Neue Figur zur Liste hinzufügen
        {
            Figuren.Add(figur);
        }
    }
}
