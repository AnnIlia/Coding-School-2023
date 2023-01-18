using System;

namespace MySession_07
{
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
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            MessageText = text;
        }
    }

}