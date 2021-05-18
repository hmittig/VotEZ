﻿using System;
using System.Collections.Generic;

namespace VotEZModels
{
    public class User
    {
        private String name;
        private String email;
        private Boolean isAdmin;
        private Poll poll;

        public int ID 
        {
            get;
            set;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public Boolean IsAdmin
        {
            get { return this.isAdmin; }
            set { this.isAdmin = value; }
        }

        public ICollection<Poll> Poll { get; set; }
        public ICollection<PollVote> PollVote { get; set; }
    }
}
