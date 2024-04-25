using System;
namespace DictionaryDs;

class Program 
{
    public static void Main(string[] args)
    {
        CustomDictionary<string, string> mydictionary = new CustomDictionary<string, string> ();
        mydictionary.Add("SF4632","Rahul");
        mydictionary.Add("SF4633","Maxine");
        mydictionary.Add("SF4634","Lucas");
        mydictionary.Add("SF4635","Will");
        mydictionary.Add("SF4636","Erica");
        mydictionary.Add("SF4637","Eddie");

        // foreach(KeyValue<string, string> data in mydictionary)
        // {
        //     System.Console.WriteLine("Key: "+data.Key+"  "+"value: "+data.Value);
        // }
    }
}