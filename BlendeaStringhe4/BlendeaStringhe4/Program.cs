using System;

namespace BlendeaStringhe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int medie = 0;
            int corte = 0;
            int lunghe = 0;
            string parola = "";
            while (parola != "fine")
            {
                Console.WriteLine("Digita una parola");
                parola = Console.ReadLine();
                int lungh = parola.Length;

                if (lungh < 4)
                {
                    corte++;
                }
                else if (lungh <= 7)
                {
                    medie++;
                }
                else
                {
                    lunghe++;
                }
            }
            Console.WriteLine($"Le parole con meno di 4 lettere sono:{ corte}");
            Console.WriteLine($"Le parole con da 4 a 7  lettere sono:{ medie - 1}");
            Console.WriteLine($"Le parole con più di 7 lettere sono:{ lunghe}");
        }
    }
}
