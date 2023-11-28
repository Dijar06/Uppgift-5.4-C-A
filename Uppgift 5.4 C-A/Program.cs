using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5] { "Ett", "Två", "Tre", "Fyra", "Fem" };
            string storst = namn[0];
            for (int i = 0; i < namn.Length; i++)
            {
                if (namn[i].CompareTo(storst) < 0)
                {
                    storst = namn[i];
                }
            }
            Console.WriteLine("Första är " + storst);
        }
    }
}