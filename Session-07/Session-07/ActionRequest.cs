using MySession_07;
using System;


namespace MySession_07
{
    public class ActionRequest
    {
        //properties
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        //constructor
        public ActionRequest()
        {
            RequestID = Guid.NewGuid();
        }
    }

}