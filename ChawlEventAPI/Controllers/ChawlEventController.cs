using ChawlEvent.Model;
using ChawlEvent.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChawlEvent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChawlEventController : ControllerBase
    {
        private readonly IChawlEventService _chawlEventService;
        private readonly ILogger<ChawlEventController> _logger;

        public ChawlEventController(IChawlEventService chawlEventService, ILogger<ChawlEventController> logger)
        {
            _chawlEventService = chawlEventService;
            _logger = logger;
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(HashSet<ChawlEventDetail> chawlEventDetails)
        {
            if (chawlEventDetails is { Count: <= 0 })
            {
                return BadRequest();
            }

            _chawlEventService.Add(chawlEventDetails);

            return Ok();
        }

        [Route("/getall")]
        [HttpGet]
        public ActionResult<HashSet<ChawlEventDetail>> GetAll()
        {
            HashSet<ChawlEventDetail> chawlEventDetails = _chawlEventService.GetAll();

            return Ok(chawlEventDetails);
        }

        [Route("/getbyid")]
        [HttpPost]
        public ActionResult<HashSet<ChawlEventDetail>> GetById(HashSet<string> ids)
        {
            HashSet<ChawlEventDetail> chawlEventDetails = _chawlEventService.GetById(ids);

            return Ok(chawlEventDetails);
        }
    }
}
