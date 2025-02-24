using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEventAPI.Repositories.Abstractions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ChawlEvent.Repositories
{
    public class ExpenseRepository : GlobalRepository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(IOptions<MongoDatabaseSetting> databaseSetting)
            : base(databaseSetting, databaseSetting.Value.ExpenseCollection)
        {

        }

        public void Add(HashSet<Expense> expenses)
        {
            if (expenses is { Count: 0 })
            {
                return;
            }

            _mongoDbRepository.Add(expenses);
        }

        public HashSet<Expense> GetAll()
        {
            return _mongoDbRepository.GetAll();
        }

        public HashSet<Expense> GetById(HashSet<string> ids)
        {
            return _mongoDbRepository.GetById(ids);
        }

        public void Update(HashSet<Expense> expenses)
        {
            foreach (var expense in expenses)
            {
                FilterDefinition<Expense> filterDefinition = Builders<Expense>.Filter.Eq(e => e.Id, expense.Id);
                UpdateDefinition<Expense> updateDefinition = Builders<Expense>.Update
                    .Set(s => s.UserId, expense.UserId)
                    .Set(s => s.Amount, expense.Amount)
                    .Set(s => s.Date, expense.Date)
                    .Set(s => s.IsSettled, expense.IsSettled);

                _mongoDbRepository.Update(filterDefinition, updateDefinition, true);
            }
        }
    }
}
