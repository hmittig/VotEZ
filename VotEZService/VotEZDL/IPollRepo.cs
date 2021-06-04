using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZDL
{
    public interface IPollRepo
    {
        Task<Poll> AddPollAsync(Poll poll);

        Task<List<Poll>> GetPollsAsync();

        Task<Poll> GetPollByIDAsync(int ID);

        Task<List<Poll>> GetPollsByUserAsync(string email);

        Task<Poll> GetPollByCodeAsync(string code);

        Task<List<Poll>> GetUserVotedPollsAsync(string email);

        Task<Poll> PollCheckAsync(string code, string email);

        Task<Poll> UpdatePollAsync(Poll poll);

        Task<Poll> DeletePollAsync(Poll poll);
    }
}
