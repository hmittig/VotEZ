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
        private string email;
        private PollChoice pollchoice;
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

        public string Email
        {
            get { return email; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                email = value;
            }
        }

        public PollChoice PollChoice 
        {
            get { return pollchoice; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                pollchoice = value;
            }
        }
    }
}
