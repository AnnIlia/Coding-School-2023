using System;

namespace Session_06
{

    public class Professor : Person
    {
        // properties

        

        public string[]? Rank { get; set; }
        string[] Rank = new string[] { "ful", "associate", "assistant" };

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
