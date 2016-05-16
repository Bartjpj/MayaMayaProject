using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Authenticatie
    {
        public static bool bedieningAuthenticatie(int x, string ww)
        {
            bool inlogcode;
            bool wachtwoord;
            if (x != 1) {
                if (x == 2552)
                {
                    inlogcode = true;
                }
            }

            if (ww != "altijdfout")
            {
                if (ww == "Welkom123")
                {
                    wachtwoord = true;
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
