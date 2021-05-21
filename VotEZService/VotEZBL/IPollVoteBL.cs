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
        // Add a new poll vote
        Task<PollVote> AddPollVoteAsync(PollVote pv);

        // Retrieve all poll votes in the database
        Task<List<PollVote>> GetPollVotesAsync();

        // Update a specified poll vote
        Task<PollVote> UpdatePollVoteAsync(PollVote pv);

        // Delete a specified poll vote
        Task<PollVote> DeletePollVoteAsync(PollVote pv);
    }
}
