using System;

namespace CustomStack;

class Program
{
    public static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);
        myStack.Push(50);
        myStack.Push(60);

        //System.Console.WriteLine(myStack.Peek());
        if(myStack.Contains(0))
        {
            System.Console.WriteLine("element is present");
        }
        else
        {
            System.Console.WriteLine("element is not present");
        }
    }
}