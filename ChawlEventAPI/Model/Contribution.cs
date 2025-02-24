using ChawlEvent.Model.Enum;

namespace ChawlEvent.Model
{
    public class Contribution
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public ContributionMode ContributionMode { get; set; }
        public DateTime Date { get; set; }
        public int ChawlEventId { get; set; }
        public bool IsSettled { get; set; }
    }
}
