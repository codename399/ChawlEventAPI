using ChawlEvent.Model;
using ChawlEvent.Services.Interfaces;
using ChawlEventAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChawlEvent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _expenseService;
        private readonly ILogger<ExpenseController> _logger;

        public ExpenseController(ExpenseService expenseService, ILogger<ExpenseController> logger)
        {
            _expenseService = expenseService;
            _logger = logger;
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(HashSet<Expense> expenses)
        {
            if (expenses is { Count: <= 0 })
            {
                return BadRequest();
            }

            _expenseService.Add(expenses);

            return Ok();
        }

        [Route("/getall")]
        [HttpGet]
        public ActionResult<HashSet<Expense>> GetAll()
        {
            HashSet<Expense> expenses = _expenseService.GetAll();

            return Ok(expenses);
        }

        [Route("/getbyid")]
        [HttpPost]
        public ActionResult<HashSet<Expense>> GetById(HashSet<string> ids)
        {
            HashSet<Expense> expenses = _expenseService.GetById(ids);

            return Ok(expenses);
        }

        [Route("/update")]
        [HttpPost]
        public ActionResult<HashSet<Expense>> Update(HashSet<Expense> expenses)
        {
            if (expenses is { Count: <= 0 })
            {
                return BadRequest();
            }

            _expenseService.Update(expenses);

            return Ok(expenses);
        }
    }
}
