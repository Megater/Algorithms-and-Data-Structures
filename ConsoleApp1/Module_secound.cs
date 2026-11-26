using System;

namespace test;

public class Module_secound
{
    public class Euklides
    {
        public static int GCD_Iter(int a, int b)
        {
            int r = 0;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        public static int GCD_Rec(int a, int b)
        {
            if (b == 0) return a;
            return GCD_Rec(b, a % b);
        }

        public static int LCM(int a, int b)
        {
            int lcm = (a*b)/GCD_Rec(a, b);
            return lcm;
        }
    }

    public static int FactoralIter(int n)
    {
        int result = 1;
        for(int i = 2; i<= n; i++) result *= i;
        return result;
    }

    public static int FactoralRec(int n)
    {
        if (n<= 1) return 1;
        return n* FactoralRec(n-1);
    }

    public static int SumIter(int n)
    {
        int result = 1;
        for(int i = 2; i <= n; i++) result += i;
        return result;
    }
    public static int SumRec(int n)
    {
        if (n<=1) return 1;
        return n + SumRec(n-1);
    }

}
