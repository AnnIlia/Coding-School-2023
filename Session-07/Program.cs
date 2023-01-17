using Session_07;
using System;

namespace Session_07
{
 //define class diagram
   
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }

    public class Message 
    {
        // properties
        public Guid RequestID { get; set; }
        public DateTime TimeStamp { get; set; }
        public String Message  { get; set; }
        //no method
    }

    public class MessageLogger : Message
    {
        // properties
        public Message[] Messages { get; set; }
       
        Message[] Messages = new Message[1000]


        // methods
        public ReadAll()
        {
            //do
        }
       
        public ClearAll()
        {
            //do
        }
        
        public Write(Message)
        {
            //do
        }

    }

    public class ActionRequest
    {
        // properties
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }
    }

    public class ActionResponse
    {
        // properties
        public Guid RequestID { get; set; }
        public Guid ResponsetID { get; set;
        public string Output { get; set; }
    }
}

    public class ActionResolver : ActionRequest
    {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver(Guid requestId)
        {
        RequestID guid = requestId;
        }

        // METHODS
        public ActionResponse Execute(ActionRequest request)
        {


            return null;
        }
    */

   
}



