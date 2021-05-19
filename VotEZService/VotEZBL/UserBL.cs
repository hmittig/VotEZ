using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZDL;
using VotEZModels;

namespace VotEZBL
{
    public class UserBL: IUserBL
    {
        private readonly IUserRepo _repo;

        public UserBL(IUserRepo repo)
        {
            _repo = repo;
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await _repo.AddUserAsync(user);
            
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _repo.GetUsersAsync();
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            return await _repo.UpdateUserAsync(user);
        }

        public async Task<User> DeleteUserAsync(User user)
        {
            return await _repo.DeleteUserAsync(user);
        }
    }
}
