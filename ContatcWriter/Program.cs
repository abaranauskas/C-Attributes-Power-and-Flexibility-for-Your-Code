using System;

namespace ContatcWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarah = new Contact
            {
                Name = "Sarah",
                AgeInYears = 18
            };

            var sarahWriter = new ContactConsoleWriter(sarah);

            sarahWriter.Write();


            Console.WriteLine("\n\nHit enter to exit...");
            Console.ReadLine();
        }
    }
}
