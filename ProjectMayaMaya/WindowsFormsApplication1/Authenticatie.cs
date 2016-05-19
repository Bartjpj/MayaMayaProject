using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Authenticatie
    {
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
