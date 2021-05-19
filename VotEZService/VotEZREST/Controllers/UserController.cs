using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotEZBL;
using VotEZModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VotEZREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL _userBL;


        public UserController(IUserBL userBL)
        {
            _userBL = userBL;
        }

        // POST api/<UserController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddUserAsync([FromBody] User user)
        {
            try
            {
                await _userBL.AddUserAsync(user);
                return CreatedAtAction("AddUser", user);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        //GET api/<UserController>/
        [HttpGet]
        public async Task<IActionResult> GetUsersAsync()
        {
            return Ok(await _userBL.GetUsersAsync());
        }

        //PUT api/<UserController>/
        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(User user)
        {
            try
            {
                await _userBL.UpdateUserAsync(user);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<UserController>/
        [HttpDelete("{user}")]
        public async Task<IActionResult> DeleteUserAsync(User user)
        {
            try
            {
                //var user = await _userBL.GetUserByIdAsync(id);
                await _userBL.DeleteUserAsync(user);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
