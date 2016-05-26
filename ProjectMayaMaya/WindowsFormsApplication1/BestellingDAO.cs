using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class BestellingDAO
    {
        private List<Bestelling> bestellingenlijst;

        public BestellingDAO(){
            bestellingenlijst = new List<Bestelling>();
            bestellingenlijst.Add(new Bestelling());
            bestellingenlijst.Add(new Bestelling(1, 1, DateTime.Today, 300, 1, true));
            bestellingenlijst.Add(new Bestelling(2, 2, DateTime.Today, 230, 2, true));
            bestellingenlijst.Add(new Bestelling(3, 3, DateTime.Today, 259, 3, true));
            bestellingenlijst.Add(new Bestelling(4, 4, DateTime.Today, 231, 4, true));


        }

        public List<Bestelling> GetAll()
        {
            return bestellingenlijst;
        }
    }
}
