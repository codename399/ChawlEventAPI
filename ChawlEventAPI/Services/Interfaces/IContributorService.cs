using ChawlEvent.Model;

namespace ChawlEvent.Services.Interfaces
{
    public interface IContributorService
    {
        public HashSet<Contributor> GetAll();
        public HashSet<Contributor> GetById(HashSet<string> ids);
        public void Add(HashSet<Contributor> contributors);
        public void Update(HashSet<Contributor> contributors);
    }
}
