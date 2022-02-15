using System;

namespace BlendeaStringhe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int uguali = 0;
            string parola = "";
            while (parola != "fine")
            {
                Console.WriteLine("Digita una parola");
                parola = Console.ReadLine();
                char letterainiziale = parola[0];
                int lungh = parola.Length;
                char letterafinale = parola[lungh - 1];
                if (letterainiziale == letterafinale)
                {
                    uguali++;
                }
            }
            Console.WriteLine($"Le parole che iniziano e finiscono con la stessa lettera sono: {uguali}");
        }
    }
}
