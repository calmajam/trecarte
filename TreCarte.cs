using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreCarte
{
    internal class TreCarte
    {
        static void Main(string[] args)
        {
            // sinistra = 1, destra = 2, centro = 3
            int posAceHearts = 1, posAceSpades = 2, posAceClubs = 3;
            int shuffleCount = 0;
            Random rand = new Random(DateTime.Now.GetHashCode());
            shuffleCount = rand.Next(1, 20);
            Console.WriteLine("Le carte verranno mescolate " + shuffleCount  + " volte");
            for (int i = 0; i < shuffleCount; i++)
            {
                shuffle(rand, ref posAceHearts, ref posAceSpades, ref posAceClubs);
                if (i < shuffleCount - 1)
                {
                    Console.WriteLine("La posizione dell'asso di cuori è " + position(posAceHearts));
                    Console.WriteLine("La posizione dell'asso di picche è " + position(posAceSpades));
                    Console.WriteLine("La posizione dell'asso di fiori è " + position(posAceClubs));
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    Console.WriteLine("Indovina dov'è l'asso di cuori? Sinistra = 1, Destra = 2, Centro = 3");
                    int response = Convert.ToInt32(Console.ReadLine());
                    if (response == posAceHearts)
                    {
                        Console.WriteLine("Hai indovinato!");
                    }
                    else
                    {
                        Console.WriteLine("Non hai indovinato.");
                        Console.WriteLine("L'asso di cuori si trova a " + position(posAceHearts) + " ("+ posAceHearts + ")");
                    }
                }
            }
        }

        static void shuffle(Random r, ref int a, ref int b, ref int c)
        {
            a = r.Next(1, 4);
            if (a == 2) {
                do
                {
                    b = r.Next(1, 4);
                }while (b == 2);
                if (b == 3) c = 1; else c = 3;
            } else if (a == 1) {
                b = r.Next(2, 4);
                if (b == 3) c = 2; else c = 3;
            } else if (a == 3) {
                b = r.Next(1, 3);
                if (b == 2) c = 1; else c = 2;
            }
        }

        static string position(int pos)
        {
            string p = "al centro";
            switch(pos)
            {
                case 1:
                     p = "a sinistra";
                    break;
                case 2:
                    p = "a destra";
                    break;
            }
            return p;
        }
    }
}
