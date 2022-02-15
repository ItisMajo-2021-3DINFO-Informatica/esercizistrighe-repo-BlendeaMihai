using System;

namespace BlendeaStringhe5
{
    class Program
    {
        static void Main(string[] args)
        {
            int iniziali = 0;
            Console.WriteLine("Digita un lettera");
            string lettera = Console.ReadLine();
            string parola = "";
            while (parola != "fine")
            {
                Console.WriteLine("inserisci una parola");
                parola = Console.ReadLine();
                char primalettera = parola[0];
                if(primalettera== lettera[0])
                {
                    iniziali++;
                }


            }
            Console.WriteLine($"Le parole che iniziano con la lettera {lettera} sono : {iniziali}");
        }
    }
}
