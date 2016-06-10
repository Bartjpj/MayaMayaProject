using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BarOverzichtClass
    {
        //Variabelen worden gedefinieerd
        public int bestelling_id { get; set; }
        public int tafel_id { get; set; }
        public int aantal { get; set; }
        public string naam { get; set; }
        public bool statusBestelling { get; set; }
        public DateTime datum_tijd { get; set; }
        public string opmerking {get; set;}

        //De constructor wordt aangemaakt
        public BarOverzichtClass(int bestelling_id, int tafel_id, int aantal, string naam, DateTime datum_tijd, string opmerking)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafel_id;
            this.aantal = aantal;
            this.naam = naam;
            this.datum_tijd = datum_tijd;
            this.opmerking = opmerking;
        }
        public BarOverzichtClass() // default constructor om objecten aan te maken zonder argumenten mee te geven, zodat ik methode bestellingGereed kan gebruiken
        {

        }
        public void bestellingGereed(int Tafelnr) // je geeft een tafelnr mee die gereed is en vervolgens wordt de statusbestelling op true gezet op het moment dat er op gereed wordt geclickt

        {
            
            this.statusBestelling = true;

         

        }
    }
}
