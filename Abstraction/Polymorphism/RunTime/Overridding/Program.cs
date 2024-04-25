using System;

namespace Overridding;

public class Animal
{
    // Method
    public virtual void Eat()   //virtual keyword gives functionality to override method
    {
        System.Console.WriteLine("Animal eats food");
    }

} 

public class Dog:Animal
{
    public override void Eat()
    {
        System.Console.WriteLine("Dog eats food");
    }
}

public class Pomerian:Dog
{
    public override void Eat()
    {
        System.Console.WriteLine("Pomerian eats food");
    }
}



class Program 
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Pomerian pomerian = new Pomerian();

        animal.Eat();
        dog.Eat();
        pomerian.Eat();

    }
}