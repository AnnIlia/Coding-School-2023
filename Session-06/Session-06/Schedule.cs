using System;

namespace Session_06
{

    public class Schedule
    {
        // properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }

        public DateTime Callendar { get; set; }

    }
}