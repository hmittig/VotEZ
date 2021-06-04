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

        // Retrieving a poll by its ID
        Task<Poll> GetPollByIDAsync(int ID);

        // Retrieving a user created poll
        Task<List<Poll>> GetPollsByUserAsync(string email);

        // Retrieving polls that a user has voted on
        Task<List<Poll>> GetUserVotedPollsAsync(string email);

        // Validating access code / checking to see if user has voted on poll before
        Task<Poll> PollCheckAsync(string code, string email);

        // Updating a specified poll
        Task<Poll> UpdatePollAsync(Poll poll);

        // Deleting a specified poll
        Task<Poll> DeletePollAsync(Poll poll);
    }
}
