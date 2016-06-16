using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class AfrekenenBLL
    {
    

    
        public int tafel_id;
        public int Aantal;
        public string Menuitem;
        public double prijs;
               

        public AfrekenenBLL(int tafel_id, int Aantal,  string Menuitem, double prijs)
        {
            
           
            this.tafel_id = tafel_id;
            this.Aantal = Aantal;
            this.Menuitem = Menuitem;
            this.prijs = prijs;
            
        }

    }
}
