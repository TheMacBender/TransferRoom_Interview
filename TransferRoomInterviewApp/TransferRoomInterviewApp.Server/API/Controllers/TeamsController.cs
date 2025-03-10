using Microsoft.AspNetCore.Mvc;
using TransferRoomInterviewApp.Server.BusinessLogic.Services.Interfaces;

namespace TransferRoomInterviewApp.Server.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly ILogger<TeamsController> _logger;
        private readonly ITeamsService _teamsService;

        public TeamsController(
            ILogger<TeamsController> logger,
            ITeamsService teamsService)
        {
            _logger = logger;
            _teamsService = teamsService;
        }

        [HttpGet()]
        public string Get()
        {
            return "Test";
        }
    }
}
