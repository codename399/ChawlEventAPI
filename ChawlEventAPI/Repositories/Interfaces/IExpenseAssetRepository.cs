using ChawlEvent.Model;

namespace ChawlEvent.Repositories.Interfaces
{
    public interface IExpenseAssetRepository
    {
        public HashSet<ExpenseAsset> GetAll();
        public HashSet<ExpenseAsset> GetById(HashSet<string> ids);
        public void Add(HashSet<ExpenseAsset> expenseAssets);
        public void Update(HashSet<ExpenseAsset> expenseAssets);
    }
}
