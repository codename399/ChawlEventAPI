using ChawlEvent.Model.Enum;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace ChawlEvent.Model
{
    public class User
    {
        [JsonIgnore]
        [BsonElement("_id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int FName { get; set; }
        public int MName { get; set; }
        public int LName { get; set; }
        public int UserName { get; set; }
        public int Password { get; set; }
        public UserType UserType { get; set; }
    }
}
