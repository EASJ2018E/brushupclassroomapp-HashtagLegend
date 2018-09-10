using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public String Navn { get; private set; }
        public int Fødselsmåned { get; private set; }
        public int Fødselsdag { get; private set; }

        
        public string FødselsÅrstid { get; set; }
        public static int VinterCounter = 0;
        public static int ForårsCounter = 0;
        public static int SommerCounter = 0;
        public static int EfterårsCounter = 0;


        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
          
            if (fødselsmåned != 1)
            {
                try
                {

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

        }

        public string Årstid()
        {
            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
            {
                FødselsÅrstid = "Vinter";
                VinterCounter++;
            }

            else if (Fødselsmåned == 3 || Fødselsmåned == 4 || Fødselsmåned == 5)
            {
                FødselsÅrstid = "Forår";
                ForårsCounter++;
            }

            else if (Fødselsmåned == 6 || Fødselsmåned == 7 || Fødselsmåned == 8)
            {
                FødselsÅrstid = "Sommer";
                SommerCounter++;
            }

            else if (Fødselsmåned == 9 || Fødselsmåned == 10 || Fødselsmåned == 11)
            {
                FødselsÅrstid = "Efterår";
                EfterårsCounter++;
            }

           return FødselsÅrstid;
        }

        public static void ÅrstidsTæller()
        {
            Console.WriteLine("Elever født i vintermånederne: "+ VinterCounter);
            Console.WriteLine("Elever født i forårsmånederne: " + ForårsCounter);
            Console.WriteLine("Elever født i sommermånederne: " + SommerCounter);
            Console.WriteLine("Elever født i efterårsmånederne: "+ EfterårsCounter);
        }



    }
}
