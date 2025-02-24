using ChawlEvent.Model;

namespace ChawlEvent.Repositories.Interfaces
{
    public interface IChawlEventRespository
    {
        public HashSet<ChawlEventDetail> GetAll();
        public void Add(HashSet<ChawlEventDetail> chawlEventDetails);

    }
}
