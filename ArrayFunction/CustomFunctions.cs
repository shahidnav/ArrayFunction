using System;

namespace ArrayFunction
{
    public static class CustomFunctions
    {
        public static int[] GetShuffledArray()
        {
            var shuffledArray = new int[1000];
            int index = 0;

            while (index < shuffledArray.Length)
            {
                shuffledArray[index] = ++index;
            }

            var randomGenerator = new Random();

            while (index > 1)
            {
                int randomIndex = randomGenerator.Next(index);
                int valueToSwap = shuffledArray[--index];
                shuffledArray[index] = shuffledArray[randomIndex];
                shuffledArray[randomIndex] = valueToSwap;
            }

            return shuffledArray;
        }
    }
}