using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZBL
{
    public interface IPollChoicesBL
    {
        // Add a new set of poll choices
        Task<PollChoice> AddPollChoicesAsync(PollChoice poll);

        // Retrieve all sets of poll choices in database
        Task<List<PollChoice>> GetPollChoicesAsync();

        // Update a specified set of poll choices
        Task<PollChoice> UpdatePollChoicesAsync(PollChoice poll);

        // Delete a specified set of poll choices
        Task<PollChoice> DeletePollChoicesAsync(PollChoice poll);
    }
}
