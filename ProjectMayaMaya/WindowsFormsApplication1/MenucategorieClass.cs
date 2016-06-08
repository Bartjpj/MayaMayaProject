using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class MenucategorieClass
    {
        public int categorie_id;
        public int kaart_id;
        public string naam;

        public MenucategorieClass(int categorie_id, int kaart_id, string naam)
        {
            this.categorie_id = categorie_id;
            this.kaart_id = kaart_id;
            this.naam = naam;
        }
    }
}
