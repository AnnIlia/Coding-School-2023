﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniLibrary
{

    public class Institute
    {
        // properties
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }

        // constructors

        public Institute()
        {
            ID = Guid.NewGuid();
        }


        // methods
        public void GetName()
        {

        }

        public void SetName(string name)
        {

        }


    }
}