using ChawlEvent.Model;

namespace ChawlEvent.Repositories.Interfaces
{
    public interface IContributionRepository
    {
        public HashSet<Contribution> GetAll();
        public HashSet<Contribution> GetById(HashSet<string> ids);
        public void Add(HashSet<Contribution> contributions);
        public void Update(HashSet<Contribution> contributions);
    }
}
