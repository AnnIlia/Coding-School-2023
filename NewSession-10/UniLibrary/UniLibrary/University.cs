﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLibrary
{


    //public class Institute
    //{

    //    public Guid ID { get; set; }
    //    public string? Name { get; set; }
    //    public int YearsInService { get; set; }


    //    public Institute()
    //    {
    //        ID = Guid.NewGuid();
    //    }
    //}

    public class University : Institute
    {


        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> Schedules { get; set; }



        public University()
        { 
            Students = new List<Student>();
            Courses = new List<Course>();   
            Grades = new List<Grade>();
            Schedules = new List<Schedule>(); 
             
        }

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

        public void SetSchedule(Guid courseID, Guid professorID)
        {

        }

    }
        
}
