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


