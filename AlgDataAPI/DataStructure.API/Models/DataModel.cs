namespace DataStructure.API.Models
{
    public class DataModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Name")]
        [JsonPropertyName("Name")]
        public string DataTypeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BigOAccesByIndex { get; set; } = null!;
        public string BigOAdditions { get; set; } = null!;
        public string BigOSearch { get; set; } = null!;
        public string BigODeletion { get; set; } = null!;

    }
}
