using ChawlEvent.Model.Enum;

namespace ChawlEvent.Model
{
    public class Contributor
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public ContributorType ContributorType { get; set; }
        public int ContributionId { get; set; }
    }
}
