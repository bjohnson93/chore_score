using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chore_score.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChoresController : ControllerBase
    {

        private readonly ChoresService _choresService;

        public ChoresController(ChoresService choresService)
        {
            _choresService = choresService;
        }
        [HttpGet]

        public ActionResult<List<Chore>> GetChores()
        {
            try
            {
                List<Chore> chores = _choresService.GetChores();
                return Ok();
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message)
            }
        }
    }
}