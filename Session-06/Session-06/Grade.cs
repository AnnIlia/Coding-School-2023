using System;

namespace Session_06
{

    public class Grade
    {
        // properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }

        public int grade { get; set; }

    }
}
