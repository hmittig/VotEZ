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

        Task<Poll> UpdatePollAsync(Poll poll);

        Task<Poll> DeletePollAsync(Poll poll);
    }
}
