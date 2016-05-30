using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    
    class DinerKaartClass
    {
        //Variabelen worden gedefinieerd
        public int bestelling_id { get; set; }
        public int tafel_id { get; set; }
        public int aantal { get; set; }
        public string naam { get; set; }

        //De constructor wordt aangemaakt
        public DinerKaartClass(int bestelling_id, int tafel_id, int aantal, string naam)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafel_id;
            this.aantal = aantal;
            this.naam = naam;
        }
    }
}
