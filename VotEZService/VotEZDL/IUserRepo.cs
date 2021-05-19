using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZDL
{
    public interface IUserRepo
    {
        Task<User> AddUserAsync(User user);

        Task<List<User>> GetUsersAsync();

        Task<User> UpdateUserAsync(User user);

        Task<User> DeleteUserAsync(User user);

    }
}
