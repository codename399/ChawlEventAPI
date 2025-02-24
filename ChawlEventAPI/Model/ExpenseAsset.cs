using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ChawlEvent.Model
{
    public class ExpenseAsset
    {
        [JsonIgnore]
        [BsonElement("_id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
    }
}
