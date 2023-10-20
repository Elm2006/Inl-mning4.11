using System;
namespace Inlämning_4.__11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord");
            string ord = Console.ReadLine();
            string gånger = "";
            for (int i = 0; i < ord.Length; i++)
            {
                for (int j = 0; j != i && j < ord.Length; j++)
                {
                    if (ord[i] == ord[j] && !gånger.Contains(ord[i]))
                    {
                        Console.WriteLine(ord[j] + " Förekommer mer än 1 gång");
                        gånger += ord[j];
                    }
                }
            }
        }
    }
}