using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEventAPI.Repositories.Abstractions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ChawlEvent.Repositories
{
    public class ExpenseAssetRepository : GlobalRepository<ExpenseAsset>, IExpenseAssetRepository
    {
        public ExpenseAssetRepository(IOptions<MongoDatabaseSetting> databaseSetting)
            : base(databaseSetting, databaseSetting.Value.ExpenseAssetCollection)
        {

        }

        public void Add(HashSet<ExpenseAsset> expenseAssets)
        {
            if (expenseAssets is { Count: 0 })
            {
                return;
            }

            _mongoDbRepository.Add(expenseAssets);
        }

        public HashSet<ExpenseAsset> GetAll()
        {
            return _mongoDbRepository.GetAll();
        }

        public HashSet<ExpenseAsset> GetById(HashSet<string> ids)
        {
            return _mongoDbRepository.GetById(ids);
        }

        public void Update(HashSet<ExpenseAsset> expenseAssets)
        {
            foreach (var expenseAsset in expenseAssets)
            {
                FilterDefinition<ExpenseAsset> filterDefinition = Builders<ExpenseAsset>.Filter.Eq(e => e.Id, expenseAsset.Id);
                UpdateDefinition<ExpenseAsset> updateDefinition = Builders<ExpenseAsset>.Update
                    .Set(s => s.Name, expenseAsset.Name);

                _mongoDbRepository.Update(filterDefinition, updateDefinition, true);
            }
        }
    }
}
