namespace Algorithms.API.DTOs
{
    public class SortResultDTO
    {
        public List<int> SortedValues { get; set; }
        public double TimeOfCalculation { get; set; }
        public int CountOfComparisons { get; set; }

    }
}
