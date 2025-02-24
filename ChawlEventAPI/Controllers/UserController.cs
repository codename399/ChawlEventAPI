using ChawlEvent.Model;
using ChawlEvent.Services.Interfaces;
using ChawlEventAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChawlEvent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(UserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(HashSet<User> users)
        {
            if (users is { Count: <= 0 })
            {
                return BadRequest();
            }

            _userService.Add(users);

            return Ok();
        }

        [Route("/getall")]
        [HttpGet]
        public ActionResult<HashSet<User>> GetAll()
        {
            HashSet<User> users = _userService.GetAll();

            return Ok(users);
        }

        [Route("/getbyid")]
        [HttpPost]
        public ActionResult<HashSet<User>> GetById(HashSet<string> ids)
        {
            HashSet<User> users = _userService.GetById(ids);

            return Ok(users);
        }

        [Route("/update")]
        [HttpPost]
        public ActionResult<HashSet<User>> Update(HashSet<User> users)
        {
            if (users is { Count: <= 0 })
            {
                return BadRequest();
            }

            _userService.Update(users);

            return Ok(users);
        }
    }
}
