using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLibrary
{

    public class Student : Person
    {
        // properties
        public int RegistrationNumber { get; set; }
        public Course[]? courses { get; set; }


        // methods
        public void Attend(string Course, DateTime dateTime)
        {

        }

        public void WriteExam(string Course, DateTime dateTime)
        {

        }
    }

}

