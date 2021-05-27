using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZDL;
using VotEZModels;

namespace VotEZBL
{
    public class PollBL: IPollBL
    {
        private readonly IPollRepo _repo;

        public PollBL(IPollRepo repo)
        {
            _repo = repo;
        }

        public async Task<Poll> AddPollAsync(Poll poll)
        {
            return await _repo.AddPollAsync(poll);

        }

        public async Task<List<Poll>> GetPollsAsync()
        {
            return await _repo.GetPollsAsync();
        }
        public async Task<List<Poll>> GetPollsByUserAsync(string email)
        {
            return await _repo.GetPollsByUserAsync(email);
        }

        public async Task<Poll> PollCheckAsync(string code, string email)
        {
            return await _repo.PollCheckAsync(code, email);
        }

        public async Task<Poll> UpdatePollAsync(Poll poll)
        {
            return await _repo.UpdatePollAsync(poll);
        }

        public async Task<Poll> DeletePollAsync(Poll poll)
        {
            return await _repo.DeletePollAsync(poll);
        }
    }
}
