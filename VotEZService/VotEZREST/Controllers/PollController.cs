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
    public class PollController : ControllerBase
    {
        private readonly IPollBL _pollBL;


        public PollController(IPollBL pollBL)
        {
            _pollBL = pollBL;
        }

        // POST api/<PollController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddPollAsync([FromBody] Poll poll)
        {
            try
            {
                await _pollBL.AddPollAsync(poll);
                return CreatedAtAction("AddPoll", poll);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        //GET api/<PollControllerr>/
        [HttpGet]
        public async Task<IActionResult> GetPollsAsync()
        {
            return Ok(await _pollBL.GetPollsAsync());
        }

        //PUT api/<PollController>/
        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(Poll poll)
        {
            try
            {
                await _pollBL.UpdatePollAsync(poll);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<PollController>/
        [HttpDelete]
        public async Task<IActionResult> DeletePollAsync(Poll poll)
        {
            try
            {
                //var user = await _userBL.GetUserByIdAsync(id);
                await _pollBL.DeletePollAsync(poll);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
