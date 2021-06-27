using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZDL
{
    public class PollVoteRepoDB: IPollVoteRepo
    {
        private readonly VotEZDBContext _context;

        public PollVoteRepoDB(VotEZDBContext context)
        {
            _context = context;
        }

        public async Task<PollVote> AddPollVoteAsync(PollVote pv)
        {
            await _context.PollVote.AddAsync(pv);
            await _context.SaveChangesAsync();
            return pv;
        }

        public async Task<List<PollVote>> GetPollVotesAsync()
        {
            return await _context.PollVote
                .Select(pv => pv)
                .ToListAsync();
        }

        public async Task<PollVote> GetUserVoteSinglePollAsync(int pollID, string email)
        {
            return await _context.PollVote
                .FirstOrDefaultAsync(pv => pv.PollID == pollID && pv.Email == email);
        }

        public async Task<PollVote> UpdatePollVoteAsync(PollVote pv)
        {
            PollVote oldpv = await _context.PollVote.FindAsync(pv.ID);
            _context.Entry(oldpv).CurrentValues.SetValues(pv);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return pv;
        }

        public async Task<PollVote> DeletePollVoteAsync(PollVote pv)
        {
            _context.PollVote.Remove(pv);
            await _context.SaveChangesAsync();
            return pv;
        }

        public async Task<int> GetOption1TotalAsync(int pollID, string option)
        {
            var result =
                from pv in _context.PollVote
                join pc in _context.PollChoices
                on pv.Choice equals pc.Option1
                where pv.PollID == pollID && pv.Choice == option
                select pv;
            List<PollVote> newList = new List<PollVote>();
            foreach (var pv in result)
            {
                newList.Add(pv);
            }
            return newList.Count;
        }

        public async Task<int> GetOption2TotalAsync(int pollID, string option)
        {
            var result =
                from pv in _context.PollVote
                join pc in _context.PollChoices
                on pv.Choice equals pc.Option2
                where pv.PollID == pollID && pv.Choice == option
                select pv;
            List<PollVote> newList = new List<PollVote>();
            foreach (var pv in result)
            {
                newList.Add(pv);
            }
            return newList.Count;
        }

        public async Task<int> GetOption3TotalAsync(int pollID, string option)
        {
            var result =
                from pv in _context.PollVote
                join pc in _context.PollChoices
                on pv.Choice equals pc.Option3
                where pv.PollID == pollID && pv.Choice == option
                select pv;
            List<PollVote> newList = new List<PollVote>();
            foreach (var pv in result)
            {
                newList.Add(pv);
            }
            return newList.Count;
        }
    }
}
