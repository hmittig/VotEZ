using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZDL
{
    public interface IPollVoteRepo
    {
        Task<PollVote> AddPollVoteAsync(PollVote pv);

        Task<List<PollVote>> GetPollVotesAsync();

        Task<PollVote> GetUserVoteSinglePollAsync(int pollID, string email);

        Task<PollVote> UpdatePollVoteAsync(PollVote pv);

        Task<PollVote> DeletePollVoteAsync(PollVote pv);

        Task<int> GetOption1TotalAsync(int pollID, string option);

        Task<int> GetOption2TotalAsync(int pollID, string option);

        Task<int> GetOption3TotalAsync(int pollID, string option);
    }
}
