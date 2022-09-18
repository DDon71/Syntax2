using System;

namespace Syntax2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("I liked math too!");
                    break;

                case "Science":
                    Console.WriteLine("Science was alot of fun");
                    break;

                case "English":
                    Console.WriteLine("English was a hard subject");
                    break;

                case "History":
                    Console.WriteLine("History is my favorite subject");
                    break;

                case "Music":
                    Console.WriteLine("I hated music");
                    break;

                default:
                    Console.WriteLine("Interesting.");
                    break;
            }

        }
    }
}

