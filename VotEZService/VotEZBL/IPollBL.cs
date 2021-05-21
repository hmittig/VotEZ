using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZBL
{
    public interface IPollBL
    {
        // Adding a poll
        Task<Poll> AddPollAsync(Poll poll);
        
        // Retrieving all polls in database
        Task<List<Poll>> GetPollsAsync();

        // Updating a specified poll
        Task<Poll> UpdatePollAsync(Poll poll);

        // Deleting a specified poll
        Task<Poll> DeletePollAsync(Poll poll);
    }
}
