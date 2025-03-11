using Microsoft.AspNetCore.Mvc;
using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly ILogger<TeamsController> _logger;
        private readonly ITeamsService _teamsService;
        private readonly IPlayersService _playersService;

        public TeamsController(
            ILogger<TeamsController> logger,
            ITeamsService teamsService,
            IPlayersService playersService)
        {
            _logger = logger;
            _teamsService = teamsService;
            _playersService = playersService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Team>> Get([FromQuery]string searchInput = "")
        {
            return Ok(_teamsService.GetTeamsBySearchInput(searchInput));
        }

        [HttpGet("{teamId}")]
        public ActionResult<Team> GetByTeamId([FromRoute]int teamId)
        {
            // temporarily
            var team = _teamsService.GetTeamByTeamId(teamId);
            if (team == null)
            {
                return NotFound();
            }

            return Ok(team);
        }

        [HttpGet("{teamId}/players")]
        public ActionResult<IEnumerable<Player>> GetPlayersByTeamId([FromRoute]int teamId)
        {
            return Ok(_playersService.GetPlayersByTeamId(teamId));
        }
    }
}
