using System;

namespace Session_06
{

    public class Professor : Person
    {
        // properties
        public string? Rank { get; set; }
   
        public Course[] ?courses { get; set; }

               
        // methods
        public void Teach(string Course, DateTime dateTime)
        {

        }

        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {
            //evaluate srudent
        }
        public void GetName()
        {
            //Dr + name(person)
        }
        
    }
}
