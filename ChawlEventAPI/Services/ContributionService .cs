using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEvent.Services.Interfaces;

namespace ChawlEventAPI.Services
{
    public class ContributionService : IContributionService
    {
        private readonly IContributionRepository _contributionRepository;

        public ContributionService(IContributionRepository contributionRepository)
        {
            _contributionRepository = contributionRepository;
        }

        public void Add(HashSet<Contribution> contributions)
        {
            _contributionRepository.Add(contributions);
        }

        public HashSet<Contribution> GetAll()
        {
            return _contributionRepository.GetAll();
        }

        public HashSet<Contribution> GetById(HashSet<string> ids)
        {
            return _contributionRepository.GetById(ids);
        }

        public void Update(HashSet<Contribution> contributions)
        {
            _contributionRepository.Update(contributions);
        }
    }
}
