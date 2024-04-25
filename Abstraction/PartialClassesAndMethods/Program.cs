using System;

namespace PartialClassesAndMethods;

class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails personal = new PersonalDetails ();
        
        personal.DOB = new DateTime(2001,08,23);

        System.Console.WriteLine(personal.CalculateAge());
    }
}