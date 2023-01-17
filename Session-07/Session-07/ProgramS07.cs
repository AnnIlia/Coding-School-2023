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
       // public String Message { get; set; }
        //no method
    }

    public class MessageLogger : Message
    {
        // properties
        public Message[] Messages { get; set; }

        Message[] Messages = new Message[1000];


        // methods
        public int ReadAll()
        {
            //do
            return 1;
        }

        public int ClearAll()
        {
            //do
            return 1;
        }

        public int Write(string Message)
        {
            //do
            return 1;
        }

    }

    public class ActionRequest
    {
        // properties
        public Guid RequestID { get; set; }
        public string Input { get; set; }
      //  public ActionEnum Action { get; set; }

        // methods (request4 from exercise)



    }


    public class ActionResponse
    {
        // properties
        public Guid RequestID { get; set; }
        public Guid ResponsetID { get; set; }
        public string Output { get; set; }
    }

    public class ActionResolver : ActionRequest
    {

        // properties
       // public MessageLogger Logger { get; set; }

        // Constructor
        public ActionResolver(Guid requestId)
        {
            RequestID guid = requestId;
        }

        // methods
        public ActionResponse Execute(ActionRequest request)
        {


            return null;
        }
    }
}

