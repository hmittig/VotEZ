using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotEZBL;
using VotEZModels;
using Serilog;

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

        //GET api/<PollController>/
        [HttpGet]
        public async Task<IActionResult> GetPollsAsync()
        {
            return Ok(await _pollBL.GetPollsAsync());
        }

        //GET api/<PollController>
        [HttpGet("{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetPollsByIDAsync(int id)
        {
            var poll = await _pollBL.GetPollByIDAsync(id);
            if (poll == null) return NotFound();
            return Ok(poll);
        }

        //GET api/<PollController>
        [HttpGet("createdpolls/{email}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetPollsByUserAsync(string email)
        {
            var poll = await _pollBL.GetPollsByUserAsync(email);
            if (poll == null) return NotFound();
            return Ok(poll);
        }

        //GET api/<PollController>
        [HttpGet("votedpolls/{email}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetUserVotedPollsAsync(string email)
        {
            var poll = await _pollBL.GetUserVotedPollsAsync(email);
            if (poll == null) return NotFound();
            return Ok(poll);
        }

        //GET api/<PollController>/
        [HttpGet("{code},{email}")]
        [Produces("application/json")]
        public async Task<IActionResult> PollCheckAsync(string code, string email)
        {
            var poll = await _pollBL.PollCheckAsync(code, email);
            if (poll == null) return NotFound();
            return Ok(poll);
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
        [HttpDelete("{ID}")]
        public async Task<IActionResult> DeletePollAsync(int ID)
        {
            try
            {
                var poll = await _pollBL.GetPollByIDAsync(ID);
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
