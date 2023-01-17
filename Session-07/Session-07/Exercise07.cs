using Session_07;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

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
        public Guid? RequestID { get; set; }
        public DateTime TimeStamp { get; set; }
        public String Message { get; set; }
        //no method
    }

    public class MessageLogger : Message
    {
        // properties
        public Message[] Messages { get; set; }

        Message[] Messages = new Message[1000];


        // methods
        public ReadAll()
        {
            //do
            return
        }

        public ClearAll()
        {
            //do
            return
        }

        public Write(Message)
        {
            //do
            return 
        }

    }

    public class ActionRequest
    {
        // properties
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        // methods (request4 from exercise)

        public class Shape
        {

            public double Move(ActionEnum Action, string? input, string? output)
            {

                double result = 0;

                switch (Action)
                {
                    case Action.Convert:

                        result = Action(output);
                        break;

                    case Action.Uppercase:

                        result = Action(output);
                        break;

                    case Action.Reverse:

                        result = Action(output);
                        break;

                    default:
                        Console.WriteLine("Error Message");
                        break;
                }

                return Action;

            }


            public double Conver(string input, string output, string result)
            {

                Console.Write("Input a Number : ");
                string input = "";
                string output = ""; 

                string input = Console.ReadLine();

                if (Decimal.TryParse(input, // ---- //      //convert      )

                else Console.Write(" Error Converter");


                return output;
            }

            public double Uppercasae ()
            {

                Console.Write("Input word of queue of words");
                string input =  Console.ReadLine();


                
                return output;
            }

            public double Reverse(string input, string output)
            {

                Console.WriteLine("Enter a string");
                string text = Console.ReadLine();
                int Length = 0;
                reverse = 
                Length = text.Length - 1;
                while (Length >= 0)
                {
                    reverse = reverse + name[Length];
                    Length--;
                }

                Console.WriteLine($"Your revesed name is {reverse}");
                Console.ReadLine();

            }
             

                return surface;
            }


        }





        public double Action(ActionEnum Convert, string Input, string result)
        {

         









                    



}
    }













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
        public MessageLogger Logger { get; set; }

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

