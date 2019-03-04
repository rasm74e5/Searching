using System;

namespace Searching
{
    public class Search
    {
        public static int FindPositionInList_Linear(int[] data, int value)
        {
            bool found = false;
            int idx = 0;
            
            while (!found && idx < data.Length)
            {
                found = data[idx] == value;
                if (!found) { idx++; }
            }
            if (!found)
            {
                idx = -1;
            }
            return idx;
        }
        public static int FindPositionInList_Binary(int[] data, int value)
        {
            int min = 0;
            int max = data.Length -1;
            while (min <= max)
            {
                int mid = min + (max - min) / 2;
                if (value == data[mid])
                {
                    return mid;
                }
                else if (value < data[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

    }

}
