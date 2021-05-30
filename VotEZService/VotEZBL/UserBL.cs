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
        private IUserRepo _repo;
        public UserBL(IUserRepo repo)
        {
            _repo = repo;
        }

        public async Task<User> AddUserAsync(User newUser)
        {
            return await _repo.AddUserAsync(newUser);
        }

        public async Task<User> DeleteUserAsync(User user)
        {
            return await _repo.DeleteUserAsync(user);
        }

        //Get user by email
        public async Task<User> GetUserByEmail(string email)
        {
            User user2Return = await _repo.GetUserByEmail(email);

            if (user2Return == null) //add user to DB if they do not exist
            {
                user2Return = new User();
                user2Return.Email = email;
                return await _repo.AddUserAsync(user2Return);
            }
            else //otherwise just return the found user
            {
                return user2Return;
            }
        }
        //Get user by Id
        public async Task<User> GetUserByIDAsync(int Id)
        {
            return await _repo.GetUserByIDAsync(Id);
        }
        //Get all users
        public async Task<List<User>> GetUsersAsync()
        {
            return await _repo.GetUsersAsync();
        }

        //Update a user
        public async Task<User> UpdateUserAsync(User user2BUpdated)
        {
            return await _repo.UpdateUserAsync(user2BUpdated);
        }
    }
}
