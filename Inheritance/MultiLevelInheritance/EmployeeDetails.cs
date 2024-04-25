using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmployeeDetails
    {
        //field
        private static int s_employeeID = 3000;

        public string EmployeeID { get; set; }

        public string Designation { get; set; }


        //constructor
        public EmployeeDetails(string designation)
        {
            s_employeeID++;
            EmployeeID = "EID"+s_employeeID;
            Designation = designation;

        }
    }
}