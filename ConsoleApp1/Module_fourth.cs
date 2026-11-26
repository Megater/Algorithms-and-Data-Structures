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

    public static void SelectionSort(int[] arr)
    {
        for(int i = 0; i<=arr.Length - 2; i++)
        {
            int minIndex = i;
            for(int j = i+1;j<=arr.Length - 1; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if(minIndex != i)
            {
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
            }
        }
    }

}
