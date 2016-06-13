using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class AfrekenenClass
    {
        public string naam;
        public int prijs;
        public int tafel_id;
        public int btw;
        public int categorie_id;

        public AfrekenenClass(string naam, int prijs, int tafel_id, int btw, int categorie_id)
        {
            this.naam = naam;
            this.prijs = prijs;
            this.tafel_id = tafel_id;
            this.btw = btw;
            this.categorie_id = categorie_id;
        }

    }
}
