﻿using System;

namespace Session_06
{

    public class Professor
    {
        // properties
        public int RegistrationNumber { get; set; }
        public Course[] ?courses { get; set; }



        // methods
        public void Teach(string Course, DateTime dateTime)
        {

        }

        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {

        }
        public void GetName(string name)
        {

        }
        //TODO: add "Dr" to GetName
    }
}
