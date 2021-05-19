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
    public class PollVoteController : ControllerBase
    {
        private readonly IPollVoteBL _pvBL;


        public PollVoteController(IPollVoteBL pvBL)
        {
            _pvBL = pvBL;
        }

        // POST api/<PollVoteController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddPollVoteAsync([FromBody] PollVote pv)
        {
            try
            {
                await _pvBL.AddPollVoteAsync(pv);
                return CreatedAtAction("AddPollVote", pv);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        //GET api/<PollVoteController>/
        [HttpGet]
        public async Task<IActionResult> GetPollsAsync()
        {
            return Ok(await _pvBL.GetPollVotesAsync());
        }

        //PUT api/<PollVoteController>/
        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(PollVote pv)
        {
            try
            {
                await _pvBL.UpdatePollVoteAsync(pv);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<PollVoteController>/
        [HttpDelete]
        public async Task<IActionResult> DeletePollAsync(PollVote pv)
        {
            try
            {
                //var user = await _userBL.GetUserByIdAsync(id);
                await _pvBL.DeletePollVoteAsync(pv);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
