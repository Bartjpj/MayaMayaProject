using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class Bestelling
    {
        private int bestelling_id;

      //  public int Bestelling_id
        //{
        //    get { return bestelling_id; }
         //   private set { bestelling_id = value; }
       // }
       
        private int tafel_id { get; set; }
        public string datum { get; set; }
        public string tijd {get; set;}
        public int voorraad { get; set; }
        public int kaart_id { get; set; }
        public bool betaald { get; set; }

        public override string ToString() // zorgt ervoor dat de gegevens in de listbox naar strings kunnen worden omgezet.
        {


            return Convert.ToString(betaald);

        }

        public Bestelling(int bestelling_id, int tafel_id, string datum, string tijd, int voorraad, int kaart_id, bool betaald)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafel_id;
            this.datum = datum;
            this.tijd = tijd;
            this.voorraad = voorraad;
            this.kaart_id = kaart_id;
            this.betaald = betaald;

        }




        public void doeEenBestelling(int bestelling_id, int tafel_id, int datum, int tijd, int voorraad, int kaart_id, int betaald){

        }


    }
}
