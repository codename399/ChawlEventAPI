using ChawlEvent.Model;
using ChawlEvent.Repositories;
using ChawlEvent.Repositories.Interfaces;
using ChawlEvent.Services.Interfaces;

namespace ChawlEventAPI.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public void Add(HashSet<Expense> expenses)
        {
            _expenseRepository.Add(expenses);
        }

        public HashSet<Expense> GetAll()
        {
            return _expenseRepository.GetAll();
        }

        public HashSet<Expense> GetById(HashSet<string> ids)
        {
            return (_expenseRepository.GetById(ids));
        }

        public void Update(HashSet<Expense> expenses)
        {
            _expenseRepository.Update(expenses);
        }
    }
}
