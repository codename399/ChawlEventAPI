using ChawlEvent.Model;
using ChawlEvent.Repositories;
using ChawlEvent.Repositories.Interfaces;
using ChawlEvent.Services.Interfaces;

namespace ChawlEventAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(HashSet<User> users)
        {
            _userRepository.Add(users);
        }

        public HashSet<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public HashSet<User> GetById(HashSet<string> ids)
        {
            return _userRepository.GetById(ids);
        }

        public void Update(HashSet<User> users)
        {
            _userRepository.Update(users);
        }
    }
}
