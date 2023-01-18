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

    }

 public class MessageLogger 
    {
    
    }

public class ActionRequest
    {

    } 

public class ActionResponse
    {

    }





}




