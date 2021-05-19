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
    public class PollChoiceController : ControllerBase
    {
        private readonly IPollChoicesBL _pcBL;


        public PollChoiceController(IPollChoicesBL pcBL)
        {
            _pcBL = pcBL;
        }

        // POST api/<PollChoiceController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddPollChoicesAsync([FromBody] PollChoice pc)
        {
            try
            {
                await _pcBL.AddPollChoicesAsync(pc);
                return CreatedAtAction("AddPollChoices", pc);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        //GET api/<PollChoiceController>/
        [HttpGet]
        public async Task<IActionResult> GetPollChoicesAsync()
        {
            return Ok(await _pcBL.GetPollChoicesAsync());
        }

        //PUT api/<PollChoiceController>/
        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(PollChoice pc)
        {
            try
            {
                await _pcBL.UpdatePollChoicesAsync(pc);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<PollChoiceController>/
        [HttpDelete]
        public async Task<IActionResult> DeletePollAsync(PollChoice pc)
        {
            try
            {
                //var user = await _userBL.GetUserByIdAsync(id);
                await _pcBL.DeletePollChoicesAsync(pc);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
