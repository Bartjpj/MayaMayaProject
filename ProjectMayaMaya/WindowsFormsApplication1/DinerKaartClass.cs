using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    
    public class DinerKaartClass
    {


        //Variabelen worden gedefinieerd
        public int menu_id { get; set; }
        public int categorie_id { get; set; }
        public string naam { get; set; }
        public double prijs { get; set; }
        public int voorraad { get; set; }

        //De constructor wordt aangemaakt
        public DinerKaartClass(int menu_id, int categorie_id, string naam, double prijs, int voorraad)
        {
            this.menu_id = menu_id;
            this.categorie_id = categorie_id;
            this.naam = naam;
            this.prijs = prijs;
            this.voorraad = voorraad;
        }


    }
    
}
