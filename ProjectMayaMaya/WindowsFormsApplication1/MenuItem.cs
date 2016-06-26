using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    
    public class MenuItem
    {
        //Variabelen worden gedefinieerd
        public int menu_id;
        public int categorie_id;
      
        public double prijs;
        public int voorraad;
        
        //voor bar en keukenoverzicht
        public int bestelling_id { get; set; }
        public int tafel_id { get; set; }
        public string naam { get; set; }
        public bool statusBestelling { get; set; }
        public DateTime datum_tijd { get; set; }

        public int aantal { get; set; }
        public string opmerking { get; set; }

        public MenuItem(int bestelling_id, int tafel_id, int aantal, string naam, DateTime datum_tijd, string opmerking)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafel_id;
            this.aantal = aantal;
            this.naam = naam;
            this.datum_tijd = datum_tijd;
            this.opmerking = opmerking;
        }

        //De constructor wordt aangemaakt
        public MenuItem(int menu_id, int categorie_id, string naam, double prijs, int voorraad)
        {
            this.menu_id = menu_id;
            this.categorie_id = categorie_id;
            this.naam = naam;
            this.prijs = prijs;
            this.voorraad = voorraad;
        }

        // default constructor

        public MenuItem()
        {

        }
    }
    
}
