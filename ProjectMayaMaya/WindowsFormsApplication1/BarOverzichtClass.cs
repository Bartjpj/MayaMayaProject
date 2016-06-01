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

        //De constructor wordt aangemaakt
        public BarOverzichtClass(int bestelling_id, int tafel_id, int aantal, string naam)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafel_id;
            this.aantal = aantal;
            this.naam = naam;
        }
        public BarOverzichtClass() // default constructor om objecten aan te maken zonder argumenten mee te geven, zodat ik methode bestellingGereed kan gebruiken
        {

        }
        public bool bestellingGereed(bool isGereed)
        {
            bool isGereedGemeld = isGereed;
            return isGereedGemeld;

        }
    }
}
