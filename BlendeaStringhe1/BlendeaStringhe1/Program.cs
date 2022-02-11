using System;

namespace BlendeaStringhe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vocali = 0;
            int consonanti = 0;
            string parola = "";
            while (parola != "fine")
            {
                Console.WriteLine("Scrivi una parola");
                parola = Console.ReadLine();
                if( parola[0] == 'a')
                {
                    vocali++;
                }
                else if(parola[0] == 'e')
                {
                    vocali++;
                }
                else if(parola[0] == 'i')
                {
                    vocali++;
                }
                else if(parola[0] == 'o')
                {
                    vocali++;
                }
                else if(parola[0] == 'u')
                {
                    vocali++;
                }
                else
                {
                    consonanti++;
                }

            }
            Console.WriteLine($"Le consonanti sono {consonanti - 1}");
            Console.WriteLine($"Le vocali sono {vocali}");
        }
    }
}
