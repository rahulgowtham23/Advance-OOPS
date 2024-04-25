using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Gender{Male, Female}
    public class PersonalDetails
    {

        //static field
        private static int s_userID = 1000;


        //properties
        public string UserID { get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber { get; set; }


        //constructor
        public PersonalDetails(string name, string fatherName, Gender gender, long phoneNumber)
        {
            //auto incrementation
            s_userID++;

            UserID = "UID"+s_userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }


        public PersonalDetails(string userID,string name, string fatherName, Gender gender, long phoneNumber)
        {
            //auto incrementation
        

            UserID = userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }        
    }
}