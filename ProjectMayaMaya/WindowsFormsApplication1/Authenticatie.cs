using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Authenticatie
    {
        public bool inlogcode;
        public bool wachtwoord;
        public bool bedieningAuthenticatie(int x, string ww)
        {
            
            if (x != 1) {
                if (x == 2552)
                {
                    this.inlogcode = true;
                }
            }

            if (ww != "altijdfout")
            {
                if (ww == "Welkom123")
                {
                    this.wachtwoord = true;
                }
            }

            if (wachtwoord && inlogcode)
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
