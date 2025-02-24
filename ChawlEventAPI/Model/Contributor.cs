using ChawlEvent.Model.Enum;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ChawlEvent.Model
{
    public class Contributor
    {
        [JsonIgnore]
        [BsonElement("_id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public ContributorType ContributorType { get; set; }
        public int ContributionId { get; set; }
    }
}
