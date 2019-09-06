using System;

namespace LessonOneReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a random phrase");
            string chars = Console.ReadLine();
            char[] characters = chars.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
                Console.Write(" " + characters[i]);
        }
    }
}
