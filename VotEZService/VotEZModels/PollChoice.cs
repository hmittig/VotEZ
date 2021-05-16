using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotEZModels
{
    class PollChoice
    {
        private Poll poll;
        private String option1;
        private String option2;
        private String option3;

        public int ID { get; set; }

        public Poll Poll
        {
            get { return poll; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                poll = value;
            }
        }

        public String Option1
        {
            get { return option1; }
            set { option1 = value; }
        }

        public String Option2
        {
            get { return option2; }
            set { option1 = value; }
        }

        public String Option3
        {
            get { return option3; }
            set { option3 = value; }
        }
    }
}
