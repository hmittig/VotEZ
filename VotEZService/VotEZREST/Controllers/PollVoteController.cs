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

        //GET api/<PollVoteController>
        [HttpGet("/total1/{id},{option1}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetOption1TotalAsync(int id, string option1)
        {
            var option = await _pvBL.GetOption1TotalAsync(id, option1);
            if (option == null) return NotFound();
            return Ok(option);
        }

        //GET api/<PollVoteController>
        [HttpGet("/total2/{id},{option2}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetOption2TotalAsync(int id, string option2)
        {
            var option = await _pvBL.GetOption2TotalAsync(id, option2);
            if (option == null) return NotFound();
            return Ok(option);
        }

        //GET api/<PollVoteController>
        [HttpGet("/total3/{id},{option3}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetOption3TotalAsync(int id, string option3)
        {
            var option = await _pvBL.GetOption3TotalAsync(id, option3);
            if (option == null) return NotFound();
            return Ok(option);
        }
    }
}
