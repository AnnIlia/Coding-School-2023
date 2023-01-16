using System;

namespace Session_06
{

    public class Professor : Person
    {
        // properties

        

        public string[]? Rank { get; set; }

       
        public Course[] ?courses { get; set; }

        /*
         TODO: add rank of {'full', 'associate', 'assistant'}
         maybe with:
        string[] Rank = new string[] { "ful", "associate", "assistant" };
         */

       
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
