using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class keukenOverzichtClass
    {
        //Variabelen worden gedefinieerd
        public int bestelling_id { get; set; }
        public int tafel_id { get; set; }
        public int aantal { get; set; }
        public string naam { get; set; }
        public bool statusBestelling { get; set; }
        public DateTime datum_tijd { get; set; }
        public string opmerking { get; set; }
        //De constructor wordt aangemaakt
        public keukenOverzichtClass(int bestelling_id, int tafel_id, string naam, int aantal, DateTime datum_tijd, string opmerking)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafel_id;
            this.aantal = aantal;
            this.naam = naam;
            this.datum_tijd = datum_tijd;
            this.opmerking = opmerking;
        }
        public keukenOverzichtClass(){}
    }
}