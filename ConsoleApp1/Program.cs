using System.Reflection;
using test;


//Module 1

//Task1
Console.WriteLine(Module_first.IsPrime(7));

Console.WriteLine("-----------------------------------");

//task2
foreach(int i in Module_first.Sieve(13))
{
    Console.WriteLine(i);
}
Console.WriteLine("-----------------------------------");
//task3
Console.WriteLine(Module_first.SqrtNewton(10,0));
Console.WriteLine("-----------------------------------");
//task4
Console.WriteLine(Module_first.CaesarCipher("Ukgoc", -2));
Console.WriteLine("-----------------------------------");


//Module 2
Console.WriteLine("-----------------------------------");
Console.WriteLine("-----------------------------------");
Console.WriteLine("-----------------------------------");

//Task 5
Console.WriteLine(Module_secound.Euklides.GCD_Iter(12, 25));
Console.WriteLine(Module_secound.Euklides.GCD_Rec(12, 18));
Console.WriteLine(Module_secound.Euklides.LCM(4, 6));
Console.WriteLine("-----------------------------------");

//Task 6
Console.WriteLine(Module_secound.FactoralIter(5));
Console.WriteLine(Module_secound.FactoralRec(4));
Console.WriteLine(Module_secound.SumIter(5));
Console.WriteLine(Module_secound.SumRec(4));
Console.WriteLine("-----------------------------------");


//Module 3

Random rnd = new Random();
int[] arr = new int[10];
for(int i = 0; i<10; i++)
{
    arr[i] = rnd.Next(0, 10);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.WriteLine();
//Task 7
Console.WriteLine(Module_third.LinearSearch(arr, 5));

//Task 8
int[] arr_sort = new int[10];
for(int i = 0; i < 10; i++)
{
    arr_sort[i] = i;
}
Console.WriteLine();
Console.WriteLine(Module_third.BinarySearch(arr_sort, 5));

//Module 4
Console.WriteLine();
//Task 9
int[] new_arr = arr;
Module_fourth.BubbleSort(new_arr);
foreach(int i in new_arr)
{
    Console.Write(i);
}

Console.WriteLine();
int[] new_arr2 = arr;
Module_fourth.SelectionSort(new_arr2);
foreach(int i in new_arr2)
{
    Console.Write(i);
}