using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class MenukaartClass
    {
        public int kaart_id;
        public string naam;

        public MenukaartClass(int kaart_id, string naam)
        {
            this.kaart_id = kaart_id;
            this.naam = naam;
        }
    }
}
