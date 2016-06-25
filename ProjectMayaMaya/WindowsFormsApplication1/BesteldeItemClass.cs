using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BesteldeItemClass : MenuItem
    {
        public int aantal; // class die is aangemaakt om het aantal te wijzigen van een bestelditem
        public string opmerking;

        public BesteldeItemClass(int menu_id, int categorie_id, string naam, double prijs, int voorraad, int aantal, string opmerking)
            : base(menu_id, categorie_id, naam, prijs, voorraad)
        {
            this.aantal = aantal;
            this.opmerking = opmerking;
        }
    }
}
