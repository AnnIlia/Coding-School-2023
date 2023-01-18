using System;
using System.Xml;

namespace MySession_07
{
    public class ActionResponse
    {
        //properties
        public Guid RequestID { set; get; }
        public Guid ResponseID { set; get; }
        public string Output { get; set; }

        //constructor
        public ActionResponse()
        {
            ResponseID = Guid.NewGuid();
        }

    }


}
