using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotEZModels
{
    public class Poll
    {
        private String question;
        private String code;
        private DateTime datetoclose;
        private int userID;
        private int pollchoiceID;
        public int ID { get; set; }

        public String Question
        {
            get { return question; }
            set { question = value; }
        }

        public String Code
        {
            get { return code; }
            set { code = value; }
        }

        public DateTime DateToClose
        {
            get { return datetoclose; }
            set { datetoclose = value; }
        }

        public int UserID
        {
            get { return userID; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                userID = value;
            }
        }

        public int PollChoiceID 
        {
            get { return pollchoiceID; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                pollchoiceID = value;
            }
        }
    }
}
