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
        Task<PollChoice> AddPollChoicesAsync(PollChoice poll);

        Task<List<PollChoice>> GetPollChoicesAsync();

        Task<PollChoice> UpdatePollChoicesAsync(PollChoice poll);

        Task<PollChoice> DeletePollChoicesAsync(PollChoice poll);
    }
}
