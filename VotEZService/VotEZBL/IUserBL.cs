using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZBL
{
    public interface IUserBL
    {
        Task<User> AddUserAsync(User user);

        Task<List<User>> GetUsersAsync();

        Task<User> UpdateUserAsync(User user);

        Task<User> DeleteUserAsync(User user);
    }
}
