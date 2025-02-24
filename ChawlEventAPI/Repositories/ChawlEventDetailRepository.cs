using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEventAPI.Repositories.Abstractions;
using Microsoft.Extensions.Options;

namespace ChawlEvent.Repositories
{
    public class ChawlEventDetailRepository : GlobalRepository<ChawlEventDetail>, IChawlEventDetailRepository
    {
        public ChawlEventDetailRepository(IOptions<MongoDatabaseSetting> databaseSetting)
            : base(databaseSetting, databaseSetting.Value.ChawlEventDetailCollection)
        {

        }

        public void Add(HashSet<ChawlEventDetail> chawlEventDetails)
        {
            if (chawlEventDetails is { Count: 0 })
            {
                return;
            }

            _mongoDbRepository.Add(chawlEventDetails);
        }

        public HashSet<ChawlEventDetail> GetAll()
        {
            return _mongoDbRepository.GetAll();
        }

        public HashSet<ChawlEventDetail> GetById(HashSet<string> ids)
        {
            return _mongoDbRepository.GetById(ids);
        }
    }
}
