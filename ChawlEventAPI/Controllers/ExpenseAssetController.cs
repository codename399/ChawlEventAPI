using ChawlEvent.Model;
using ChawlEvent.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChawlEvent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseAssetController : ControllerBase
    {
        private readonly IExpenseAssetService _expenseAssetService;
        private readonly ILogger<ExpenseAssetController> _logger;

        public ExpenseAssetController(IExpenseAssetService expenseAssetService, ILogger<ExpenseAssetController> logger)
        {
            _expenseAssetService = expenseAssetService;
            _logger = logger;
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(HashSet<ExpenseAsset> expenseAssets)
        {
            if (expenseAssets is { Count: <= 0 })
            {
                return BadRequest();
            }

            _expenseAssetService.Add(expenseAssets);

            return Ok();
        }

        [Route("/getall")]
        [HttpGet]
        public ActionResult<HashSet<ExpenseAsset>> GetAll()
        {
            HashSet<ExpenseAsset> expenseAssets = _expenseAssetService.GetAll();

            return Ok(expenseAssets);
        }

        [Route("/getbyid")]
        [HttpPost]
        public ActionResult<HashSet<ExpenseAsset>> GetById(HashSet<string> ids)
        {
            HashSet<ExpenseAsset> expenseAssets = _expenseAssetService.GetById(ids);

            return Ok(expenseAssets);
        }

        [Route("/update")]
        [HttpPost]
        public ActionResult<HashSet<ExpenseAsset>> Update(HashSet<ExpenseAsset> expenseAssets)
        {
            if (expenseAssets is { Count: <= 0 })
            {
                return BadRequest();
            }

            _expenseAssetService.Update(expenseAssets);

            return Ok(expenseAssets);
        }
    }
}
