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
        public int kaart_id { get; set; }
        public int categorie_id { get; set; }
        public string naam { get; set; }
        public int prijs { get; set; }
        public int voorraad { get; set; }

        //De constructor wordt aangemaakt
        public DinerKaartClass(int kaart_id, int categorie_id, string naam, int prijs, int voorraad)
        {
            this.kaart_id = kaart_id;
            this.categorie_id = categorie_id;
            this.naam = naam;
            this.prijs = prijs;
            this.voorraad = voorraad;
        }
    }
    
}
