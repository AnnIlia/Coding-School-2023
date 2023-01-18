using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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

        //constructor
        public Message()
        {
            ID = Guid.NewGuid();        
        }
        public Message(string text)
        {
            ID= Guid.NewGuid();
            TimeStamp= DateTime.Now;
            MessageText = text;
        }
    }

    public class MessageLogger
    {
        //properties
        public Message[] Messages { get; set; }

        //constructor
        public MessageLogger()
        {
            Messages= new Message[1000];
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

        public class ActionRequest
        {
            //properties
            public Guid RequestID { get; set; }
            public string Input { get; set; }
            public ActionEnum Action { get; set; }

            //constructor
            public ActionRequest()
            {
                ResponseID= Guid.NewGuid();
            }


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
                ActionResponse response = new ActionResponse();
                response.ResponseID = Guid.NewGuid(); 
                response.RequestID = request.RequestID;
                
                MessageLogger logger= new MessageLogger();
                Message message = new Message('execution start');
                

                logger.Messages[0] = message;


                try
                {
                    switch (request.Action)
                    {
                        case ActionEnum.Convert:
                            response.Output = Convert(request.Input);
                            break;
                        case ActionEnum.Uppercase:
                            response.Output = Uppercase(request.Input);
                            break;
                        case ActionEnum.Reverse:
                            response.Output = Reverse(request.Input);
                            break;
                        default:
                            //TODO: error message
                            break;
                    }
                   
                }
                catch (Exception ex)
                {

                    Message message2 = new Message(ex.Message);
                    logger.Messages[1] = message2;
                                     
                }
                finally
                {
                    Message message3 = new Message("execution end");
                    logger.Messages[0] = message;
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













