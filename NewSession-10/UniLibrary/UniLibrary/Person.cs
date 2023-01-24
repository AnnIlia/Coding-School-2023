using System;

namespace Session_06
{

    public class Person
    {
        // properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        // methods
        public virtual string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

    }
}
