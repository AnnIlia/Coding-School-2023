using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySession_07 {

    public enum ActionEnum
{
    Convert, 
    Uppercase, 
    Reverse
}

    internal class ActionResolver
    {
     //properties
     public MessageLogger Logger { get; set; }  
     //constructor
     public ActionResolver()
        {

        }

    //method
    public ActionResponse Execute(ActionRequest request)
        {
            return null;
        }


    }

public class Message
    {
        //properties
        public Guid ID { get; set; }    
        public DateTime TimeStamp { get; set; } 
        //Message renamed as MessageText
        public string MessageText { get; set; }

      



    }

 public class MessageLogger 
    {
        //properties
    public Message[] Messages { get; set; }

    }
        //constructor
    public MessageLogger()
    {

    }


    public class ActionRequest
    {
        //properties
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }      
    } 

public class ActionResponse
    {
        //properties
        public Guid RequestID { set; get; }
        public Guid ResponseID { set; get; }
        public string Output { get; set; }
    }





}




