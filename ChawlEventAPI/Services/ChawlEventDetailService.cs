using ChawlEvent.Model;
using ChawlEvent.Repositories.Interfaces;
using ChawlEvent.Services.Interfaces;

namespace ChawlEventAPI.Services
{
    public class ChawlEventDetailService : IChawlEventDetailService
    {
        private readonly IChawlEventDetailRepository _chawlEventRepository;

        public ChawlEventDetailService(IChawlEventDetailRepository chawlEventRepository)
        {
            _chawlEventRepository = chawlEventRepository;
        }

        public void Add(HashSet<ChawlEventDetail> chawlEventDetails)
        {
            _chawlEventRepository.Add(chawlEventDetails);
        }

        public HashSet<ChawlEventDetail> GetAll()
        {
            return _chawlEventRepository.GetAll();
        }

        public HashSet<ChawlEventDetail> GetById(HashSet<string> ids)
        {
            return _chawlEventRepository.GetById(ids);
        }
    }
}
