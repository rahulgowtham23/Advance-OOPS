using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class CustomerDetails:PersonalDetails
    {
        //static field
        private static int s_customerID = 2000;

        public string CustomerID { get; }

        public int Balance { get; set; }



        //constructor
        public CustomerDetails(string userID,string name, string fatherName, Gender gender, long phoneNumber,int balance)
        :base(userID,name, fatherName, gender, phoneNumber)
        {
            //autoincrementation
            s_customerID++;

            CustomerID = "CID"+s_customerID;
            Balance = balance;
        }
    }
}