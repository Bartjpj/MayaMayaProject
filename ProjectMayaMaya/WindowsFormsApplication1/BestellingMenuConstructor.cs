using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BestellingMenuConstructor
    {
                //Alle delen van de database kolommen worden hier aangemaakt.
                public int BestellingId {get; set;}
                public int Aantal {get; set;}
                public int ItemId {get; set;}
                public int prijs {get; set;}

        public BestellingMenuConstructor(int BestellingId, int Aantal, int ItemId, int prijs)
        {
            this.BestellingId = BestellingId;
            this.Aantal = Aantal;
            this.ItemId = ItemId;
            this.prijs = prijs;
        } // deze constructor zorgt ervoor dat alle variabelen overal toegankelijk zijn.

    }
}
