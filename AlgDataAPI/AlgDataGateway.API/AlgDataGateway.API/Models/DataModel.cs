namespace AlgDataGateway.API.Models
{
    public class DataModel
    {
        public string? Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BigOAccesByIndex { get; set; } = null!;
        public string BigOAdditions { get; set; } = null!;
        public string BigOSearch { get; set; } = null!;
        public string BigODeletion { get; set; } = null!;
    }
}
