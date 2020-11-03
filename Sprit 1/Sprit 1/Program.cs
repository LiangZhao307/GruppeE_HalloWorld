using System;
using System.Security.Cryptography;

namespace Sprit_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Var
            double m, p, c, hf, ha, df, d;

            // Eingabe
            Console.WriteLine("Bitten geben Sie das Modul an");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitten geben Sie den Teilkreisdurchmesser an");
            d = Convert.ToInt32(Console.ReadLine());

            // Kopfspiel
            c = 0.167 * m;
            
            // Zahnfußhöhe
            hf = m + c;
            // Zahnkopfhöhe 
            ha = m;
           
            // Teilung
            p = Math.PI * m;
          
            // Fußkreisdurchmesser
            df = d + 2 * (m + c);

            // Ausgabe
            Console.WriteLine("Zahnfußhöhe = " + hf);
            Console.WriteLine("Zahnfußkopfhöhe = " + ha);
            Console.WriteLine("Teilung = " + p);
            Console.WriteLine("FUßkreisdurchmesser = " + df);

            Console.ReadLine();

        }
    }
}
