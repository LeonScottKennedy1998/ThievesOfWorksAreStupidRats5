using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tortiki
{
    internal class Cake
    {
        private string NameOfThing;
        private int CostOfThing;
        public Cake (string _NameOfThing, int _CostOfThing)
        {
            NameOfThing = _NameOfThing;

            CostOfThing = _CostOfThing;

            Console.WriteLine(NameOfThing + CostOfThing);
        }
        

        
    }
}
