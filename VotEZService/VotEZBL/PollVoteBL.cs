using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZDL;
using VotEZModels;

namespace VotEZBL
{
    public class PollVoteBL: IPollVoteBL
    {
        private readonly IPollVoteRepo _repo;

        public PollVoteBL(IPollVoteRepo repo)
        {
            _repo = repo;
        }

        public async Task<PollVote> AddPollVoteAsync(PollVote pv)
        {
            return await _repo.AddPollVoteAsync(pv);

        }

        public async Task<List<PollVote>> GetPollVotesAsync()
        {
            return await _repo.GetPollVotesAsync();
        }

        public async Task<PollVote> GetUserVoteSinglePollAsync(int pollID, string email)
        {
            return await _repo.GetUserVoteSinglePollAsync(pollID, email);
        }

        public async Task<PollVote> UpdatePollVoteAsync(PollVote pv)
        {
            return await _repo.UpdatePollVoteAsync(pv);
        }

        public async Task<PollVote> DeletePollVoteAsync(PollVote pv)
        {
            return await _repo.DeletePollVoteAsync(pv);
        }

        public async Task<int> GetOption1TotalAsync(int pollID, string option)
        {
            return await _repo.GetOption1TotalAsync(pollID, option);
        }

        public async Task<int> GetOption2TotalAsync(int pollID, string option)
        {
            return await _repo.GetOption2TotalAsync(pollID, option);
        }

        public async Task<int> GetOption3TotalAsync(int pollID, string option)
        {
            return await _repo.GetOption3TotalAsync(pollID, option);
        }
    }
}
