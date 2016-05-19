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

        public bool bedieningAuthenticatie(int inlogCode)
        {
            
           
            if (inlogCode == 2552)
            {
                inlogcode = true;
            }
            
            if (inlogcode)
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
