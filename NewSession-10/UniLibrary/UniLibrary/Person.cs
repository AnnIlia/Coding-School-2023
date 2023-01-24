using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLibrary
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
