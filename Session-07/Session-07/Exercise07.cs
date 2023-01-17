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


            public double SurfaceCircle(double radius)
            {

                double surface = 0;

                surface = radius * (double)2 * Math.PI;

                return surface;
            }

            public double SurfaceSquare(double side)
            {
                double surface = 0;

                surface = side * side;

                return surface;
            }

            public double SurfaceTriangle(double side)
            {
                double surface = 0;

                surface = (side * side) / 2;

                return surface;
            }


        }





        public double Action(ActionEnum Convert, string Input, string result)
        {

            Console.Write("Input a Number : ");
            string input = Console.ReadLine();

            if (Decimal.TryParse(input, // ---- //

                //convert
                return Convert;
                )

                else Console.Write(" Error Converter");










                    



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

