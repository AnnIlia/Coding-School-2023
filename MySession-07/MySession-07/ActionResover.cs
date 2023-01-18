using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MySession_07
{

    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }

   

    public class Message
    {
        //properties
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        //Message renamed as MessageText > cannot be the same as class name
        public string MessageText { get; set; }
    }

    public class MessageLogger
    {
        //properties
        public Message[] Messages { get; set; }


        //constructor
        public MessageLogger()
        {

        }
        //methods 
        public void ReadAll()
        {

        }
         
        public void Clear()
        {

        }

        public void Write(Message message)
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

        public class ActionResolver
        {
            //properties
            public MessageLogger Logger { get; set; }
            //constructor
            public ActionResolver()
            {

            }

            //methods
            public ActionResponse Execute(ActionRequest request)
            {


                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Convert();
                        break;
                    case ActionEnum.Uppercase:
                        Uppercase();
                        break;
                    case ActionEnum.Reverse:
                        Reverse();
                        break; 
                    default:
                        //TODO: error message
                        break;

                }



                return null;
            }


        }




    }

}







   





