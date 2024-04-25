using System;

namespace QueueDs;

class Program 
{
    public static void Main(string[] args)
    {
        CustomQueue<int> myQueue = new CustomQueue<int>();  

        myQueue.Enqueue(10);      
        myQueue.Enqueue(20);      
        myQueue.Enqueue(30);      
        myQueue.Enqueue(40);      
        myQueue.Enqueue(50);      
        myQueue.Enqueue(60);      
        myQueue.Enqueue(70);      

        System.Console.WriteLine(myQueue.Peek());
        System.Console.WriteLine(myQueue.Dequeue());
        System.Console.WriteLine(myQueue.Dequeue());
    }
}