using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasse = new KlasseRum();
            klasse.KlasseListe.Add(new Studerende("Patrick", 10, 4));
            klasse.KlasseListe.Add(new Studerende("Jesper", 3, 4));
            klasse.KlasseListe.Add(new Studerende("Hakan", 12, 24));



            Console.WriteLine(klasse.KlasseNavn);
            Console.WriteLine(klasse.KlasseListe.Count);
            Console.ReadKey();
        }
    }
}
