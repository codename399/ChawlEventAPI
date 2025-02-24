using ChawlEvent.Model;

namespace ChawlEvent.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public HashSet<User> GetAll();
        public HashSet<User> GetById(HashSet<string> ids);
        public void Add(HashSet<User> users);
        public void Update(HashSet<User> users);
    }
}
