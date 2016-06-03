using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class BestellingMenuClass
    {
        

      //  public int Bestelling_id
        //{
        //    get { return bestelling_id; }
         //   private set { bestelling_id = value; }
       // }
        public int bestelling_id { get; set; }
        public int tafel_id { get; set; }
        //public string datum { get; set; }
        //public string tijd { get; set; }
        public int ItemdId {get; set;}
        public int aantal { get; set; }
        
        //public int voorraad { get; set; }
        //public int kaart_id { get; set; }
        //public bool betaald { get; set; }

        //public override string ToString() // zorgt ervoor dat de gegevens in de listbox naar strings kunnen worden omgezet.
        //{


        //    return Convert.ToString(betaald);

        //}

        public BestellingMenuClass(int bestelling_id, int tafel_id, int aantal, int ItemId)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafel_id;
           
            this.aantal = aantal;
            this.ItemdId = ItemId;
           

     
         
        

        }




        public void doeEenBestelling(int bestelling_id, int tafel_id, int datum, int tijd, int voorraad, int kaart_id, int betaald){

        }


    }
}
