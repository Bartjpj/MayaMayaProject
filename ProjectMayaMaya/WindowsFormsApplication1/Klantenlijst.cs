using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Klantenlijst
    {
        //Alle delen van de database kolommen worden hier aangemaakt.
        public int personeel_id;
        public int tafel_id;
        public int bestelling_id;
        public string naam;
        public string functie;
        public int barnotificatie_id;
        public int keukennotificatie_id;
        public List<Klantenlijst> klantenlijstList = new List<Klantenlijst>(); //dit is de lijst waar de personeelslidtabel in opgeslagen zal worden.

        public Klantenlijst(int personeel_id, int tafel_id, int bestelling_id, string naam, string functie, int barnotificatie_id, int keukennotificatie_id)
        {
            this.personeel_id = personeel_id;
            this.tafel_id = tafel_id;
            this.bestelling_id = bestelling_id;
            this.naam = naam;
            this.functie = functie;
            this.barnotificatie_id = barnotificatie_id;
            this.keukennotificatie_id = keukennotificatie_id;
        } // deze functie zorgt ervoor dat alle variabelen overal toegankelijk zijn.


        public bool inlogBoolean;

        public bool bedieningAuthenticatie(int inlogCode)
        {


            
                if (inlogCode == 2552)
                {
                    inlogBoolean = true;
                }
            
            
            if (inlogBoolean)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
