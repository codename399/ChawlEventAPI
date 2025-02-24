using ChawlEvent.Model;
using ChawlEvent.Repositories;
using ChawlEvent.Repositories.Interfaces;
using ChawlEvent.Services.Interfaces;

namespace ChawlEventAPI.Services
{
    public class ExpenseAssetService : IExpenseAssetService
    {
        private readonly IExpenseAssetRepository _expenseAssetRepository;

        public ExpenseAssetService(IExpenseAssetRepository expenseAssetRepository)
        {
            _expenseAssetRepository = expenseAssetRepository;
        }

        public void Add(HashSet<ExpenseAsset> expenseAssets)
        {
            _expenseAssetRepository.Add(expenseAssets);
        }

        public HashSet<ExpenseAsset> GetAll()
        {
            return _expenseAssetRepository.GetAll();
        }

        public HashSet<ExpenseAsset> GetById(HashSet<string> ids)
        {
            return _expenseAssetRepository.GetById(ids);
        }

        public void Update(HashSet<ExpenseAsset> expenseAssets)
        {
            _expenseAssetRepository.Update(expenseAssets);
        }
    }
}
