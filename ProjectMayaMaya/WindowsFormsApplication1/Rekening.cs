using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Rekening
    {
        rekeningEnum BetaalwijzeEnum; // er zijn 3 betaalwijzes pin, contant creditcard
        
        public double totaaPrijs; //veld om totaalprijs in te stoppen
        public int hoeveelheidMenuitem;

        public Bestelling Bestelling
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        } // veld om de hoeveelheidMenu-items aan te geven

        private void berekenTotaalPrijs(){
        }
        private void geefFooi(){

        }
        public void printRekening(){}
        public void betaalWijze(rekeningEnum betaalWijze){}
        

      
        }
    }

