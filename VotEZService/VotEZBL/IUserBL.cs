using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZBL
{
    public interface IUserBL
    {
        // Adds a new user
        Task<User> AddUserAsync(User user);

        // Retrieves all users in the database
        Task<List<User>> GetUsersAsync();

        // Updates a specified user
        Task<User> UpdateUserAsync(User user);

        // Deletes a specified user
        Task<User> DeleteUserAsync(User user);
    }
}
