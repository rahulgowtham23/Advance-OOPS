using System;

namespace AbstractClassesAndMethods;

class Program
{
    public static void Main(string[] args)
    {
        Syncfusion job1 = new Syncfusion();
        job1.Name = "Steve";
        System.Console.WriteLine(job1.Display());
        System.Console.WriteLine(job1.Salary(30));
    }
}