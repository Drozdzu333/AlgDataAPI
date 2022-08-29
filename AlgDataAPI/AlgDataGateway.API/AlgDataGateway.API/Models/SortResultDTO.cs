namespace AlgDataGateway.API.Models
{
    public class SortResultDTO
    {
        public List<int> SortedValues { get; set; }
        public float TimeOfCalculation { get; set; }
        public int CountOfComparisons { get; set; }
    }
}
