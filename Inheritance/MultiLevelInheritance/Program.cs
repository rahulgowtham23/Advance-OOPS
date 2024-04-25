using System;

namespace MultiLevelInheritance;

class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails person = new PersonalDetails("Rahul","Rengaraj",Gender.Male,879632541);
        System.Console.WriteLine("|UserID|Name|FatherName|Gender|MobileNumber|");
        //System.Console.WriteLine($"|{person.UserID}|{person.Name}|{person.FatherName}|{person.Gender}|{person.PhoneNumber}|");


        StudentDetails details = new StudentDetails(person.UserID,person.Name,person.FatherName,person.Gender,person.PhoneNumber,5,"2014");
        System.Console.WriteLine($"|{person.UserID}|{details.Name}|{details.FatherName}|{details.Gender}|{details.PhoneNumber}|{details.StudentID}|{details.Standard}|{details.YearOfJoining}|");
    }
}