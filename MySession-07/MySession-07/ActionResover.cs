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
                try
                {
                    switch (request.Action)
                    {
                        case ActionEnum.Convert:
                            output = Convert(request.Input);
                            break;
                        case ActionEnum.Uppercase:
                            output = Uppercase(request.Input);
                            break;
                        case ActionEnum.Reverse:
                            output = Reverse(request.Input);
                            break;
                        default:
                            //TODO: error message
                            break;
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

                return null;

            }

            private string Convert(string input)
            {
                //do comvert as requested
                return string.Empty;
            }
            private string Uppercase(string input)
            {
                //do uppercase as requested
                return string.Empty;
            }
            private string Reverse(string input) 
            {
                //do reverse as requested
                return string.Empty;
            }

        }




    }

}













