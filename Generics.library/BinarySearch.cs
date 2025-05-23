using System;

namespace Generics.library
{
    public class BinarySearch
    {
        static public int Search(int[] array, int value)
        {
            return Search(array, value, 0, array.Length - 1); 
        }

        private static int Search(int[] array, int value, int minIndex, int maxIndex)
        {
            //base case: value was not found in the list
            if (minIndex > maxIndex)
                return -1;

            //TODO: find middle Index of the list
            int middleIndex = minIndex + (maxIndex - minIndex) / 2;

            //Check if that value == value => return the index (value was found) !
            if (array[middleIndex] == value)
                return middleIndex;

            //If that value is greater, repeat the same in the left side of the list
            else if (array[middleIndex] > value)
                return Search(array, value, minIndex, middleIndex - 1); 

            //If that value is smaller, repeat the same in th right side of the list
            else //if (list[middleIndex] < value)
                return Search(array, value, middleIndex  + 1, maxIndex);
        }
    }
}
