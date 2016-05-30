using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class TafelOverzichtConstructor
    {
        // properties van Tafel
        public int TafelId { get; set; }
        public bool Bezet { get; set; }

        public TafelOverzichtConstructor(int TafelId, bool Bezet)
        {
            this.TafelId = TafelId;
            this.Bezet = Bezet;
        }
        
    }
}