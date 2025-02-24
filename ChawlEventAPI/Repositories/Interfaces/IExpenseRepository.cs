using ChawlEvent.Model;

namespace ChawlEvent.Repositories.Interfaces
{
    public interface IExpenseRepository
    {
        public HashSet<Expense> GetAll();
        public HashSet<Expense> GetById(HashSet<string> ids);
        public void Add(HashSet<Expense> expenses);
        public void Update(HashSet<Expense> expenses);
    }
}
