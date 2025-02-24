using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ChawlEvent.Model
{
    public class ChawlEventDetail
    {
        [JsonIgnore]
        [BsonElement("_id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
