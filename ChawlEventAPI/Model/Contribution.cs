using ChawlEvent.Model.Enum;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ChawlEvent.Model
{
    public class Contribution
    {
        [JsonIgnore]
        [BsonElement("_id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Amount { get; set; }
        public ContributionMode ContributionMode { get; set; }
        public DateTime Date { get; set; }
        public int ChawlEventId { get; set; }
        public bool IsSettled { get; set; }
    }
}
