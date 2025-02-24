using ChawlEvent.Model;
using ChawlEvent.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChawlEvent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContributionController : ControllerBase
    {
        private readonly IContributionService _contributionService;
        private readonly ILogger<ContributionController> _logger;

        public ContributionController(IContributionService contributionService, ILogger<ContributionController> logger)
        {
            _contributionService = contributionService;
            _logger = logger;
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(HashSet<Contribution> contributions)
        {
            if (contributions is { Count: <= 0 })
            {
                return BadRequest();
            }

            _contributionService.Add(contributions);

            return Ok();
        }

        [Route("/getall")]
        [HttpGet]
        public ActionResult<HashSet<Contribution>> GetAll()
        {
            HashSet<Contribution> contributions = _contributionService.GetAll();

            return Ok(contributions);
        }

        [Route("/getbyid")]
        [HttpPost]
        public ActionResult<HashSet<Contribution>> GetById(HashSet<string> ids)
        {
            HashSet<Contribution> contributions = _contributionService.GetById(ids);

            return Ok(contributions);
        }

        [Route("/update")]
        [HttpPost]
        public ActionResult<HashSet<Contribution>> Update(HashSet<Contribution> contributions)
        {
            if (contributions is { Count: <= 0 })
            {
                return BadRequest();
            }

            _contributionService.Update(contributions);

            return Ok(contributions);
        }
    }
}
