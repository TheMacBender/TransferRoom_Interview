using Microsoft.AspNetCore.Mvc;
using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;
using TransferRoomInterviewApp.Server.Domain;

namespace TransferRoomInterviewApp.Server.API.Controllers
{
    /// <summary>
    /// Controller responsible for orchestrating requests for Teams and Players for particular Team.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamsService _teamsService;
        private readonly IPlayersService _playersService;

        /// <summary>
        /// Controller for TeamsController class.
        /// </summary>
        /// <param name="teamsService">Responsible for mapping retrieved results into Team domain model.</param>
        /// <param name="playersService">Responsible for mapping retrieved results into Player domain model.</param>
        public TeamsController(
            ITeamsService teamsService,
            IPlayersService playersService)
        {
            _teamsService = teamsService;
            _playersService = playersService;
        }

        /// <summary>
        /// Endpoint to provide list of Teams with names or nicknames matching the search input.
        /// </summary>
        /// <param name="searchInput">Filters out Teams that have no matching names or nicknames. If is empty, result is also empty.</param>
        /// <returns>List of Teams without links to badges</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> Get([FromQuery]string searchInput = "")
        {
            var result = await _teamsService.GetTeamsBySearchInputAsync(searchInput);
            return Ok(result);
        }

        /// <summary>
        /// Endpoint to provide details for a chosen Team. This endpoint relies on data from external API.
        /// </summary>
        /// <param name="teamId">Id of a Team we want to get details for. Matches the ones defined by external API.</param>
        /// <returns>Team details including a link to badge</returns>
        /// <response code="404">No Team has been found. Can be also an information that the external API doesn't cooperate</response>
        [HttpGet("{teamId}")]
        public async Task<ActionResult<Team>> GetByTeamId([FromRoute]int teamId)
        {
            var team = await _teamsService.GetTeamByTeamIdAsync(teamId);
            if (team == null)
            {
                return NotFound();
            }

            return Ok(team);
        }

        /// <summary>
        /// Endpoint to provide current Team squad made of Players for a chosen Team. This endpoint relies on data from external API.
        /// </summary>
        /// <param name="teamId">Id of a Team we want to get details for. Matches the ones defined by external API.</param>
        /// <returns>List of Players currently playing for requested Team.</returns>
        [HttpGet("{teamId}/players")]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayersByTeamId([FromRoute]int teamId)
        {
            var result = await _playersService.GetPlayersByTeamIdAsync(teamId);
            return Ok(result);
        }
    }
}
