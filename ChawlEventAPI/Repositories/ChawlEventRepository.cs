using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using DatabaseRespository.MongoDb;

namespace ChawlEvent.Repositories
{
    public class ChawlEventRepository : IChawlEventRespository
    {
        private IMongoDbRepository<ChawlEventDetail> _mongoDbRepository;

        public ChawlEventRepository()
        {
            _mongoDbRepository = new MongoDbRepository<ChawlEventDetail>(Util.Util.GetConnectionString(),"ChawlEvent");
        }
        public void Add(HashSet<ChawlEventDetail> chawlEventDetails)
        {
            throw new NotImplementedException();
        }

        public HashSet<ChawlEventDetail> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
