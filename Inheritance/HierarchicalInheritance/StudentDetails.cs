using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class StudentDetails : PersonalDetails
    {
        //field static
        private static int s_studentID = 2000;

        //field
        public string StudentID { get; }
        public int Standard { get; set; }
        public string YearOfJoining { get; set; }



        //Constructor
        public StudentDetails(string userID,string name, string fatherName,Gender gender, long phoneNumber, int standard, string yearOfJoining):base(name, fatherName, gender, phoneNumber)
        {
            //auto incrementaion
            s_studentID++;

            StudentID = "SID"+s_studentID;
            Standard = standard;
            YearOfJoining = yearOfJoining;

        }

        


    }
}