using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEventAPI.Repositories.Abstractions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ChawlEvent.Repositories
{
    public class ContributionRepository : GlobalRepository<Contribution>, IContributionRepository
    {
        public ContributionRepository(IOptions<MongoDatabaseSetting> databaseSetting)
            : base(databaseSetting, databaseSetting.Value.ContributionCollection)
        {

        }

        public void Add(HashSet<Contribution> contributions)
        {
            if (contributions is { Count: 0 })
            {
                return;
            }

            _mongoDbRepository.Add(contributions);
        }

        public HashSet<Contribution> GetAll()
        {
            return _mongoDbRepository.GetAll();
        }

        public HashSet<Contribution> GetById(HashSet<string> ids)
        {
            return _mongoDbRepository.GetById(ids);
        }

        public void Update(HashSet<Contribution> contributions)
        {
            foreach (var contribution in contributions)
            {
                FilterDefinition<Contribution> filterDefinition = Builders<Contribution>.Filter.Eq(e => e.Id, contribution.Id);
                UpdateDefinition<Contribution> updateDefinition = Builders<Contribution>.Update
                    .Set(s => s.Amount, contribution.Amount)
                    .Set(s => s.Date, contribution.Date)
                    .Set(s => s.ContributionMode, contribution.ContributionMode)
                    .Set(s => s.IsSettled, contribution.IsSettled);

                _mongoDbRepository.Update(filterDefinition, updateDefinition, true);
            }
        }
    }
}
