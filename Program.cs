using System;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 6 cijelih brojeva: ");
            string unos = Console.ReadLine();
            string[] brojeviString = unos.Split(",");
            int[] cijeliBrojevi = new int[6];
            int[] neparniBrojevi = new int[6];
            bool pozitivni = true;
            int j = 0;
            for (int i = 0; i < cijeliBrojevi.Length; i++) {
                cijeliBrojevi[i] = Int32.Parse(brojeviString[i]);
                if(cijeliBrojevi[i] < 0) pozitivni = false;
                if (cijeliBrojevi[i] % 2 != 0) neparniBrojevi[j++] = cijeliBrojevi[i];
            }

            if (!pozitivni) Console.WriteLine("Nisu svi brojevi pozitivni!");
            else Console.WriteLine("Svi brojevi su pozitivni!");

            // dobra caka sa ternarnim operatorom
            /*
             string ispis = pozitivni ? "Svi su pozitivni" : "Nisu svi pozitivni";
             */
            
            /*Dobra caka sa string.Join*/
            Console.WriteLine("Neparni brojevi su: " + string.Join(", ", neparniBrojevi[0..j]));
        }
    }
}
