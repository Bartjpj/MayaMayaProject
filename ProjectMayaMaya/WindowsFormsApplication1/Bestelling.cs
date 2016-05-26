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
        private int tafel_id = 1;
        private DateTime besteldatum;
        private int voorraad;
        private int kaart_id;
        private bool betaald;

        public Bestelling()
        {

        }

        public Bestelling(int bestelling_id, int tafelId, DateTime besteldatum, int voorraad, int kaartid, bool betaald)
        {
            this.bestelling_id = bestelling_id;
            this.tafel_id = tafelId;
            this.besteldatum = besteldatum;
            this.voorraad = voorraad;
            this.kaart_id = kaart_id;
            this.betaald = betaald;

        }

        private void neemBestellingOp()
        {

            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;

            SqlConnection connectie = new SqlConnection(connString);
            connectie.Open();

            string sql = String.Format("INSERT INTO Bestelling(bestelling_id, tafel_id)" + "values('{0}','{2}')", bestelling_id, tafel_id);
            SqlCommand command = new SqlCommand(sql, connectie);
            int rowsAffected = command.ExecuteNonQuery();
          
            SqlDataReader reader = command.ExecuteReader(); // datareaderobject

          
        }
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
