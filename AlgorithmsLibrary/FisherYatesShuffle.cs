using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public static class FisherYatesShuffle
    {
        private static Random _randomNumber = new Random();

        public static void DoFisherYatesShuffle(this object[] objects)
        {
            for (int i = objects.Length - 1; i > 0; i--)
            {
                Swap(objects, i, GetNumber(i));
            }
        }

        private static void Swap(object[] objects, int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;

        }

        private static int GetNumber(int i)
        {
            return _randomNumber.Next(i + 1);
        }
    }
}
