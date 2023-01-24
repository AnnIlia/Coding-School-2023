using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLibrary
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
    
        public override string GetName()
        {
           return ("Dr " + base.GetName());
        }
        
    }
}
