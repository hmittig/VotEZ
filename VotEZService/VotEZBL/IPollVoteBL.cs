﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZBL
{
    public interface IPollVoteBL
    {
        Task<PollVote> AddPollVoteAsync(PollVote pv);

        Task<List<PollVote>> GetPollVotesAsync();

        Task<PollVote> UpdatePollVoteAsync(PollVote pv);

        Task<PollVote> DeletePollVoteAsync(PollVote pv);
    }
}
