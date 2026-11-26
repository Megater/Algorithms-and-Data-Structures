using System;

namespace test;

public class Module_fourth
{
    public static void BubbleSort(int[] arr)
    {
        for(int i = 0; i<=arr.Length - 1; i++)
        {
            bool swapped = false;

            for(int j = 0; j<=arr.Length - 2 - i; j++)
            {
                if(arr[j]> arr[j + 1])
                {
                    (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                    swapped = true;
                }
            }
            if(swapped == false)
            {
                break;
            }
        }
    }

}
