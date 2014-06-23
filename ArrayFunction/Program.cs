using System;

namespace ArrayFunction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] shuffledArray = CustomFunctions.GetShuffledArray();
            int index = 0;

            while (index < shuffledArray.Length)
            {
                Console.WriteLine("Position: {0}, Value: {1}", index, shuffledArray[index++]);
            }

            Console.ReadLine();
        }
    }
}