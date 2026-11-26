using System;
using System.Diagnostics.Metrics;

namespace test;

public class Module_third
{
    public static int LinearSearch(int[] arr, int target)
    {
        int counter = 1; 
        foreach(int i in arr)
        {
            if (i == target)
            {
                return counter;
            }
            counter ++;
        }
        return -1;
    }

    public static int BinarySearch(int[]arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left<= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid]< target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid -1;
            }
        }
        return -1;

    }
}
