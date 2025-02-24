using ChawlEvent.Model;

namespace ChawlEvent.Repositories.Interfaces
{
    public interface IContributorRepository
    {
        public HashSet<Contributor> GetAll();
        public HashSet<Contributor> GetById(HashSet<string> ids);
        public void Add(HashSet<Contributor> contributors);
        public void Update(HashSet<Contributor> contributors);
    }
}
