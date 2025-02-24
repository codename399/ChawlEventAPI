using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEventAPI.Repositories.Abstractions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ChawlEvent.Repositories
{
    public class UserRepository : GlobalRepository<User>, IUserRepository
    {
        public UserRepository(IOptions<MongoDatabaseSetting> databaseSetting)
            : base(databaseSetting, databaseSetting.Value.UserCollection)
        {

        }

        public void Add(HashSet<User> chawlEventDetails)
        {
            if (chawlEventDetails is { Count: 0 })
            {
                return;
            }

            _mongoDbRepository.Add(chawlEventDetails);
        }

        public HashSet<User> GetAll()
        {
            return _mongoDbRepository.GetAll();
        }

        public HashSet<User> GetById(HashSet<string> ids)
        {
            return _mongoDbRepository.GetById(ids);
        }

        public void Update(HashSet<User> users)
        {
            foreach (var user in users)
            {
                FilterDefinition<User> filterDefinition = Builders<User>.Filter.Eq(e => e.Id, user.Id);
                UpdateDefinition<User> updateDefinition = Builders<User>.Update
                    .Set(s => s.FName, user.FName)
                    .Set(s => s.MName, user.MName)
                    .Set(s => s.LName, user.LName)
                    .Set(s => s.UserType, user.UserType);

                _mongoDbRepository.Update(filterDefinition, updateDefinition, true);
            }
        }
    }
}
