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
        private int bestelling_id = 1;

      //  public int Bestelling_id
        //{
        //    get { return bestelling_id; }
         //   private set { bestelling_id = value; }
       // }
       
        private int tafel_id { get; set; }
        public DateTime datumtijd { get; set; }
        public int voorraad { get; set; }
        public int kaart_id { get; set; }
        public bool betaald { get; set; }
       

        public Bestelling(int bestelling_id, int tafelId, DateTime besteldatum, int voorraad, int kaartid, bool betaald)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafel_id;
            this.datumtijd = datumtijd;
            this.voorraad = voorraad;
            this.kaart_id = kaart_id;
            this.betaald = betaald;

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
