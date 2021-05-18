using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotEZModels
{
    public class PollVote
    {
        private User user;
        private PollChoice pollchoice;
        private String choice;

        public int ID {get;set;}

        public User User
        {
            get { return user; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                user = value;
            }
        }

        public PollChoice PollChoice
        {
            get { return PollChoice; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                PollChoice = value;
            }
        }

        public String Choice
        {
            get { return choice; }
            set { choice = value; }
        }

    }
}
