using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEventAPI.Repositories.Abstractions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ChawlEvent.Repositories
{
    public class ContributorRepository : GlobalRepository<Contributor>, IContributorRepository
    {
        public ContributorRepository(IOptions<MongoDatabaseSetting> databaseSetting)
            : base(databaseSetting, databaseSetting.Value.ContributorCollection)
        {

        }

        public void Add(HashSet<Contributor> contributors)
        {
            if (contributors is { Count: 0 })
            {
                return;
            }

            _mongoDbRepository.Add(contributors);
        }

        public HashSet<Contributor> GetAll()
        {
            return _mongoDbRepository.GetAll();
        }

        public HashSet<Contributor> GetById(HashSet<string> ids)
        {
            return _mongoDbRepository.GetById(ids);
        }

        public void Update(HashSet<Contributor> contributors)
        {
            foreach (var contributor in contributors)
            {
                FilterDefinition<Contributor> filterDefinition = Builders<Contributor>.Filter.Eq(e => e.Id, contributor.Id);
                UpdateDefinition<Contributor> updateDefinition = Builders<Contributor>.Update
                    .Set(s => s.FName, contributor.FName)
                    .Set(s => s.MName, contributor.MName)
                    .Set(s => s.LName, contributor.LName)
                    .Set(s => s.ContributorType, contributor.ContributorType);

                _mongoDbRepository.Update(filterDefinition, updateDefinition, true);
            }
        }
    }
}
