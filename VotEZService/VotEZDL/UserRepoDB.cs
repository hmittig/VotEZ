using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZDL
{
    public class UserRepoDB: IUserRepo
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

        public async Task<User> DeleteUserAsync(User user)
        {
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.User
                .Where(u => u.Email == email)
                .FirstOrDefaultAsync();
        }
        //Get a user by Id
        public async Task<User> GetUserByIDAsync(int Id)
        {
            return await _context.User
                .Where(u => u.ID == Id)
                .FirstOrDefaultAsync();
        }
        //Get a list of all users
        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.User
                .ToListAsync();
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            User oldUser = await _context.User.Where(u => u.ID == user.ID).FirstOrDefaultAsync();

            _context.Entry(oldUser).CurrentValues.SetValues(user);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return user;
        }
    }
}
