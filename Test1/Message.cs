using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Test1
{
    public class Message
    {
        private int _UserId;

        public int UserId 
            {
            get { return _UserId; }
            set { _UserId = value; }
        }
        private DateTime _SentDate;
        public DateTime SentDate 
            {
            get { return _SentDate; }
            set { _SentDate = value; }
            }

        private DateTime _ReadDate;
        public DateTime ReadDate 
            {
            get { return _ReadDate; }
            set { _ReadDate = value; }
        }


        private string _MessageText;

        public string MessageText
        {
            get{ return _MessageText; }
            set { _MessageText = value; }
        }

        public void MessageInfo(DateTime SentDate, DateTime ReadDate, string MessageText)
            {
            this.SentDate = SentDate;
            this.ReadDate = ReadDate;
            this.MessageText = MessageText;
        }
    }
}
