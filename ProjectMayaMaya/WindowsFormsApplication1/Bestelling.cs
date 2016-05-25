using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Bestelling
    {
        private int bestelling_id;

        public int Bestelling_id
        {
            get { return bestelling_id; }
            private set { bestelling_id = value; }
        }
        private int tafel_id;
        private DateTime besteldatum;
        private int voorraad;
        private int kaart_id;
        private bool betaald;
      
     
       
        private void isBetaald()
        {

        }
 

        public Tafel Tafel
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public PersoneelLid PersoneelLid
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


    }
}
