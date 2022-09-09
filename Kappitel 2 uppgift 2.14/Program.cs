using System;
namespace uppgift_2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skirv in första talet");
            string tal = Console.ReadLine();
            Console.WriteLine("Skriv in andra tal"); 
            string tal2 = Console.ReadLine();

            float tal_siffror = float.Parse(tal);
            float tal_siffror2 = float.Parse(tal2);

            Console.WriteLine("svaret är" + tal_siffror * tal_siffror2);


        }
    }
}
