using System;

namespace ByType;

class Program
{
    public static void Main(string[] args)
    {

        int result = Add(1, 2);
        double result2 = Add(1,3);  //this will go to add method because parameter is int  (give 1.0 to go double method)
        string result1 = Add("steve", "harrington");

    }
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static string Add(string a, string b)
    {
        return a + b;
    }
}