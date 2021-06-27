using System;
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

        // Retrieve a poll vote  by a user in a single poll
        Task<PollVote> GetUserVoteSinglePollAsync(int pollID, string email);

        // Update a specified poll vote
        Task<PollVote> UpdatePollVoteAsync(PollVote pv);

        // Delete a specified poll vote
        Task<PollVote> DeletePollVoteAsync(PollVote pv);

        // Total the amount of votes for option 1
        Task<int> GetOption1TotalAsync(int pollID, string option);

        // Total the amount of votes for option 2
        Task<int> GetOption2TotalAsync(int pollID, string option);

        // Total the amount of votes for option 3
        Task<int> GetOption3TotalAsync(int pollID, string option);
    }
}
