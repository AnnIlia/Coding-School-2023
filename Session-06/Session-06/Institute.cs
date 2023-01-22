using System;

namespace Session_06
{

    public class Institute
    {
        // properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }

        // methods
        public void GetName()
        {

        }

        public void SetName(string name)
        {

        }

        // inheritance
        public class University : Institute
        {

        }

    }
}