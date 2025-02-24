using ChawlEvent.Model;

namespace ChawlEvent.Repositories.Interfaces
{
    public interface IChawlEventDetailRepository
    {
        public HashSet<ChawlEventDetail> GetAll();
        public HashSet<ChawlEventDetail> GetById(HashSet<string> ids);
        public void Add(HashSet<ChawlEventDetail> chawlEventDetails);

    }
}
