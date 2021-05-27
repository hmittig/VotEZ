using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;
using VotEZDL;

namespace VotEZDL
{
    public class PollRepoDB: IPollRepo
    {
        private readonly VotEZDBContext _context;

        public PollRepoDB(VotEZDBContext context)
        {
            _context = context;
        }

        public async Task<Poll> AddPollAsync(Poll poll)
        {
            await _context.Poll.AddAsync(poll);
            await _context.SaveChangesAsync();
            return poll;
        }

        public async Task<List<Poll>> GetPollsAsync()
        {
            return await _context.Poll
                .Include("PollChoice")
                .AsNoTracking()
                .Select(poll => poll)
                .ToListAsync();
        }

        public async Task<List<Poll>> GetPollsByUserAsync(string email)
        {
            return await _context.Poll
                .Include("PollChoice")
                .AsNoTracking()
                .Select(poll => poll)
                .Where(poll => poll.Email == email)
                .ToListAsync();
        }

        public async Task<Poll> GetPollByCodeAsync(string code)
        {
            return await _context.Poll
                .Include("PollChoice")
                .AsNoTracking()
                .Select(poll => poll)
                .Where(poll => poll.Code == code && DateTime.Now < poll.DateToClose)
                .FirstOrDefaultAsync();
        }

        public async Task<Poll> PollCheckAsync(string code, string email)
        {
            Poll pc = await GetPollByCodeAsync(code);
            if (pc != null)
            {
                PollVote pv = await _context.PollVote
                           .Select(pv => pv)
                           .Where(pv => pv.PollID == pc.ID && pv.Email == email)
                           .FirstOrDefaultAsync();
                if (pv == null)
                    return pc;
                else return null;
            }
            else return null;
        }

        public async Task<Poll> UpdatePollAsync(Poll poll)
        {
            Poll oldpoll = await _context.Poll.FindAsync(poll.ID);
            _context.Entry(oldpoll).CurrentValues.SetValues(poll);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return poll;
        }

        public async Task<Poll> DeletePollAsync(Poll poll)
        {
            _context.Poll.Remove(poll);
            await _context.SaveChangesAsync();
            return poll;
        }
    }
}
