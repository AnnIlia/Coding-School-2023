using System;
using System.Globalization;

namespace Session_06
{

    public class University
    {
        // properties
        public Student[]? students { get; set; }
        public Course[]? courses { get; set; }
        public Grade[]? grades { get; set; }
        public Schedule[]? ScheduleCourse { get; set; }


        // methods
        public void GetStudents()
        {

        }

        public void GetCourses()
        {

        }

        public void GetGrades()
        {

        }

        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime datetime)
        {

        }

    }
}