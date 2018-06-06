using System;
using AlgorithmsLibrary;

namespace LearningAlgorithms
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };
            letters.DoFisherYatesShuffle();
            foreach (string letter in letters)
            {
                Console.WriteLine(" | " + letter);

            }

            Console.ReadLine();
        }
    }
}
