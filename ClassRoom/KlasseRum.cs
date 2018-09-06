using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> KlasseListe { get; set; }
        public DateTime SemesterStart { get; set; }


        public KlasseRum()
        {
            KlasseNavn = "3B";
            SemesterStart = new DateTime(2018, 9, 4);
            KlasseListe = new List<Studerende>();

        }

        //public void ÅrstidsTæller()
        //{
        //    var listOfStuderende = from studerende in KlasseListe
        //        where studerende.Årstid().Equals("Vinter")
        //        select studerende;
        //    Console.WriteLine(listOfStuderende);

        //}

    }
}

