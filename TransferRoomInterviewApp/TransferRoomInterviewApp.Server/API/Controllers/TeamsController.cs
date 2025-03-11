using Microsoft.AspNetCore.Mvc;
using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamsService _teamsService;
        private readonly IPlayersService _playersService;

        public TeamsController(
            ITeamsService teamsService,
            IPlayersService playersService)
        {
            _teamsService = teamsService;
            _playersService = playersService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> Get([FromQuery]string searchInput = "")
        {
            var result = await _teamsService.GetTeamsBySearchInputAsync(searchInput);
            return Ok(result);
        }

        [HttpGet("{teamId}")]
        public async Task<ActionResult<Team>> GetByTeamId([FromRoute]int teamId)
        {
            // temporarily
            var team = await _teamsService.GetTeamByTeamIdAsync(teamId);
            if (team == null)
            {
                return NotFound();
            }

            return Ok(team);
        }

        [HttpGet("{teamId}/players")]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayersByTeamId([FromRoute]int teamId)
        {
            var result = await _playersService.GetPlayersByTeamIdAsync(teamId);
            return Ok(result);
        }
    }
}
