using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotEZModels
{
    public class PollVote
    {
        private int userID;
        private int  pollchoiceID;
        private String choice;

        public int ID {get;set;}

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

        public String Choice
        {
            get { return choice; }
            set { choice = value; }
        }

    }
}
