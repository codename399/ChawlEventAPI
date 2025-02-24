using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ChawlEvent.Model
{
    public class Expense
    {
        [JsonIgnore]
        [BsonElement("_id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int UserId { get; set; }
        public int Amount { get; set; }
        public int ExpenseAssetId { get; set; }
        public DateTime Date { get; set; }
        public bool IsSettled { get; set; }
    }
}
