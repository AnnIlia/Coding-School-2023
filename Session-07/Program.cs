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

    public class MessageLogger
    {
        // properties
        public Message[] Messages { get; set; }
        // methods
        public ReadAll()
        {
            
        }
       
        public ClearAll()
        {
         
        }
        
        public Write(Message)
        {
         
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

    public class ActionResolver
    {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver()
        {

        }

        // METHODS
        public ActionResponse Execute(ActionRequest request)
        {


            return null;
        }
    */

   
}



