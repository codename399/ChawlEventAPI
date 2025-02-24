using ChawlEvent.Model;

namespace ChawlEvent.Services.Interfaces
{
    public interface IChawlEventService
    {
        public HashSet<ChawlEventDetail> GetAll();
        public HashSet<ChawlEventDetail> GetById(HashSet<string> ids);
        public void Add(HashSet<ChawlEventDetail> chawlEventDetails);
    }
}
