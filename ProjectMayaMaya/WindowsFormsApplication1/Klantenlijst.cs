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
        public string naam;
        public string functie;
        public int code;
        public List<Klantenlijst> personeelsTabel = new List<Klantenlijst>();

        public Klantenlijst(int personeel_id, string naam, string functie, int code)
        {
            this.personeel_id = personeel_id;
            this.naam = naam;
            this.functie = functie;
            this.code = code;
        } // deze constructor zorgt ervoor dat alle variabelen overal toegankelijk zijn.

    }
}
