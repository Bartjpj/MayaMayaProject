using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class AfrekenenBLL
    {

        public int tafel_id;
        public int Aantal;
        public int categorie_id;
        public int bestelling_id;
        public string Menuitem;
        public double prijs;



        public AfrekenenBLL(int tafel_id, int Aantal, int categorie_id, int bestelling_id, string Menuitem, double prijs)
        {


            this.tafel_id = tafel_id;
            this.Aantal = Aantal;
            this.categorie_id = categorie_id;
            this.bestelling_id = bestelling_id;
            this.Menuitem = Menuitem;
            this.prijs = prijs;


        }

    }
}