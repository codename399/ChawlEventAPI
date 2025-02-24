using ChawlEvent.Model;

namespace ChawlEvent.Services.Interfaces
{
    public interface IExpenseService
    {
        public HashSet<Expense> GetAll();
        public HashSet<Expense> GetById(HashSet<string> ids);
        public void Add(HashSet<Expense> expenses);
        public void Update(HashSet<Expense> expenses);
    }
}
