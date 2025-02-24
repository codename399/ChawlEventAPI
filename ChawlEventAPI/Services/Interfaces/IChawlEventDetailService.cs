using ChawlEvent.Model;

namespace ChawlEvent.Services.Interfaces
{
    public interface IChawlEventDetailService
    {
        public HashSet<ChawlEventDetail> GetAll();
        public HashSet<ChawlEventDetail> GetById(HashSet<string> ids);
        public void Add(HashSet<ChawlEventDetail> chawlEventDetails);
    }
}
