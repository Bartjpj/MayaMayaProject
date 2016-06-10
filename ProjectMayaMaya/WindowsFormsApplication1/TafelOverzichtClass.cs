using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class TafelOverzichtClass
    {
        //Variabelen worden gedefinieerd
        public int TafelId { get; set; }
        public bool Bezet { get; set; }

        //De constructor wordt aangemaakt
        public TafelOverzichtClass(int TafelId, bool Bezet)
        {
            this.TafelId = TafelId;
            this.Bezet = Bezet;
        }

        public TafelOverzichtClass(int TafelId)
        {
            this.TafelId = TafelId;
        }



        
    }
}