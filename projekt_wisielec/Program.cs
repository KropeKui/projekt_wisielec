using System.Reflection.Metadata.Ecma335;

namespace projekt_wisielec
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze WISIELEC");
            Console.WriteLine("Podaj hasło do gry:");
            string haslo = Console.ReadLine();
            double haslo1 = haslo.Length;
            Console.WriteLine(haslo);
            Console.WriteLine(haslo1);

            String[] litery = Array.Empty<string>();

            for (int i = 0; i < haslo1; i++)
            {
                Console.Write("_ ");

                
                //litery = litery.Concat(new string[] { haslo1[i] }).ToArray();

            }





        }
    }
}