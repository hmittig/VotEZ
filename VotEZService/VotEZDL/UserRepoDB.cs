using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZDL
{
    public class UserRepoDB : IUserRepo
    {
        private readonly VotEZDBContext _context;

        public UserRepoDB(VotEZDBContext context)
        {
            _context = context;
        }

        public async Task<User> AddUserAsync(User user)
        {
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.User
                .Select(user => user)
                .ToListAsync();
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            User olduser = await _context.User.FindAsync(user.ID);
            _context.Entry(olduser).CurrentValues.SetValues(user);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return user;
        }

        public async Task<User> DeleteUserAsync(User user)
        {
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
