using ChawlEvent.Model;
using ChawlEvent.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChawlEvent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContributorController : ControllerBase
    {
        private readonly IContributorService _contributorService;
        private readonly ILogger<ContributorController> _logger;

        public ContributorController(IContributorService contributorService, ILogger<ContributorController> logger)
        {
            _contributorService = contributorService;
            _logger = logger;
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(HashSet<Contributor> contributors)
        {
            if (contributors is { Count: <= 0 })
            {
                return BadRequest();
            }

            _contributorService.Add(contributors);

            return Ok();
        }

        [Route("/getall")]
        [HttpGet]
        public ActionResult<HashSet<Contributor>> GetAll()
        {
            HashSet<Contributor> contributors = _contributorService.GetAll();

            return Ok(contributors);
        }

        [Route("/getbyid")]
        [HttpPost]
        public ActionResult<HashSet<Contributor>> GetById(HashSet<string> ids)
        {
            HashSet<Contributor> contributors = _contributorService.GetById(ids);

            return Ok(contributors);
        }

        [Route("/update")]
        [HttpPost]
        public ActionResult<HashSet<Contributor>> Update(HashSet<Contributor> contributors)
        {
            if (contributors is { Count: <= 0 })
            {
                return BadRequest();
            }

            _contributorService.Update(contributors);

            return Ok(contributors);
        }
    }
}
