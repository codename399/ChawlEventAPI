using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEvent.Services.Interfaces;

namespace ChawlEventAPI.Services
{
    public class ContributorService : IContributorService
    {
        private readonly IContributorRepository _contributorRepository;

        public ContributorService(IContributorRepository contributorRepository)
        {
            _contributorRepository = contributorRepository;
        }

        public void Add(HashSet<Contributor> contributors)
        {
            _contributorRepository.Add(contributors);
        }

        public HashSet<Contributor> GetAll()
        {
            return _contributorRepository.GetAll();
        }

        public HashSet<Contributor> GetById(HashSet<string> ids)
        {
            return _contributorRepository.GetById(ids);
        }

        public void Update(HashSet<Contributor> contributors)
        {
            _contributorRepository.Update(contributors);
        }
    }
}
