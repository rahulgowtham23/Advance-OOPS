using System;
namespace ListDs;

class Program 
{
    public static void Main(string[] args)
    {
        // Object creation for customList
        CustomList<int> numberList = new CustomList<int>();    

        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);

        CustomList<int> numbers = new CustomList<int>();
        numbers.Add(60);
        numbers.Add(70);
        numberList.AddRange(numbers);

        // for(int i=0;i<numberList.Count;i++)
        // {
        //     System.Console.WriteLine(numberList[i]);
        // }

        // bool result = numberList.Contains(40);
        // //System.Console.WriteLine(result); 

        // int position = numberList.IndexOf(20);
        //System.Console.WriteLine(position);

        // numberList.Insert(2,100);

        // numberList.RemoveAt(3);
        // for(int i=0;i<numberList.Count;i++)
        // {
        //     System.Console.WriteLine(numberList[i]);
        // }

        // bool temp = numberList.Remove(40);

        // foreach(int value in numberList)
        // {
        //     System.Console.WriteLine(value);
        // }

        // numberList.Reverse();   

        CustomList<int> num = new CustomList<int>();
        num.Add(80);
        num.Add(90);
        
        // numberList.InsertRange(3,num);

        numberList.Sort();

    }
}