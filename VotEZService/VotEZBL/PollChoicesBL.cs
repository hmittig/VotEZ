using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZDL;
using VotEZModels;

namespace VotEZBL
{
    public class PollChoicesBL: IPollChoicesBL
    {
        private readonly IPollChoicesRepo _repo;

        public PollChoicesBL(IPollChoicesRepo repo)
        {
            _repo = repo;
        }

        public async Task<PollChoice> AddPollChoicesAsync(PollChoice pc)
        {
            return await _repo.AddPollChoicesAsync(pc);

        }

        public async Task<List<PollChoice>> GetPollChoicesAsync()
        {
            return await _repo.GetPollChoicesAsync();
        }

        public async Task<PollChoice> UpdatePollChoicesAsync(PollChoice pc)
        {
            return await _repo.UpdatePollChoicesAsync(pc);
        }

        public async Task<PollChoice> DeletePollChoicesAsync(PollChoice pc)
        {
            return await _repo.DeletePollChoicesAsync(pc);
        }
    }
}
