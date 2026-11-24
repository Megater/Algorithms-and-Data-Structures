using System;
using System.ComponentModel;

namespace test;

public class Module_first
{

    public static bool IsPrime(int n)
    {
        if(n<2) return false;
        for(int i = 2; i<=(int)(Math.Sqrt(n)); i++)
        {
            if (n%i == 0)
            {
                return false;
            } 
        }
        return true;

    }

    public static List<int> Sieve(int n)
    {
        bool[] isPrime = new bool[n+1];
        for(int i = 1;i<=n; i++)
        {
            isPrime[i] = true;
        }

        for(int i = 2; i<=(int)Math.Sqrt(n); i++)
        {
            if(isPrime[i] == true)
            {
                for(int j = i*i; j<=n; j += i)
                {
                    isPrime[j]=false;
                }
            }
        }
        List<int> numbers = new List<int>();
        for(int i = 1; i <= n; i++)
        {
            if(isPrime[i] == true)
            {
                numbers.Add(i);
            }
        }
        return numbers;

    }

    public static double SqrtNewton(double a, double epsilon)
    {
        double x = a / 2.0;
        double prevX;
        do
        {
            prevX = x;
            x = 0.5 * (x + (a / x));
        } while (Math.Abs(x - prevX) > epsilon);

        return x;

    }

    public static string CaesarCipher(string text, int key)
    {
        string chnged = "Changed text: ";
        foreach(char i in text)
        {
            char letter = i;
            chnged = chnged + (char)(letter+key);
        }

        return chnged;
    }

}
