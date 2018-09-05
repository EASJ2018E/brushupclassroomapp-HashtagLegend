using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public String Navn { get; private set; }
        public int Fødselsmåned { get; private set; }
        public int Fødselsdag { get; private set; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }

        //public override string ToString()
        //{
        //    return $"{nameof(Navn)}: {Navn}, {nameof(Fødselsmåned)}: {Fødselsmåned}, {nameof(Fødselsdag)}: {Fødselsdag}";
        //}
    }
}
