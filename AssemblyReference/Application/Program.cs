using System;



namespace Application; //File scoped namespace

class Program 
{
    public static void Main(string[] args)
    {
        //Default Data Calling
        Operations.AddDefaultData();

        //Calling Main Menu
        Operations.MainMenu();
    }
}