using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotEZModels
{
    public class PollVote
    {
        private string email;
        private int  pollID;
        private String choice;

        public int ID {get;set;}

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

        public int PollID
        {
            get { return pollID; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                pollID = value;
            }
        }

        public String Choice
        {
            get { return choice; }
            set { choice = value; }
        }

    }
}
