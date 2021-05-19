using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZDL
{
    public class PollChoicesRepoDB: IPollChoicesRepo
    {
        private readonly VotEZDBContext _context;

        public PollChoicesRepoDB(VotEZDBContext context)
        {
            _context = context;
        }

        public async Task<PollChoice> AddPollChoicesAsync(PollChoice pc)
        {
            await _context.PollChoices.AddAsync(pc);
            await _context.SaveChangesAsync();
            return pc;
        }

        public async Task<List<PollChoice>> GetPollChoicesAsync()
        {
            return await _context.PollChoices
                .Select(pc => pc)
                .ToListAsync();
        }

        public async Task<PollChoice> UpdatePollChoicesAsync(PollChoice pc)
        {
            PollChoice oldpc = await _context.PollChoices.FindAsync(pc.ID);
            _context.Entry(oldpc).CurrentValues.SetValues(pc);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return pc;
        }

        public async Task<PollChoice> DeletePollChoicesAsync(PollChoice pc)
        {
            _context.PollChoices.Remove(pc);
            await _context.SaveChangesAsync();
            return pc;
        }
    }
}
