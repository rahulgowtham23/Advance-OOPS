using System;

namespace Interface;

 class Program 
 {
    public static void Main(string[] args)
    {
        Square  number = new Square(); //class varible as a object

        number.Number = 20;

        System.Console.WriteLine(number.Calculate());


        Circle number1 = new Circle ();

        number1.Number = 20;

        System.Console.WriteLine(number1.Calculate()); 
    }

 }