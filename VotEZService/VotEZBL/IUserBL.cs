using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotEZModels;

namespace VotEZBL
{
    public interface IUserBL
    {
        //Get all users
        Task<List<User>> GetUsersAsync();
        //Get User By Email
        Task<User> GetUserByEmail(string email);
        //Get user by ID
        Task<User> GetUserByIDAsync(int id);
        //Add a user
        Task<User> AddUserAsync(User user);
        //Update a user
        Task<User> UpdateUserAsync(User user);
        //Delete a User
        Task<User> DeleteUserAsync(User user);
    }
}
