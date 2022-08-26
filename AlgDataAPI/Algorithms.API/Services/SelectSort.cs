namespace Algorithms.API.Services
{
    public class SelectSort : ISortService
    {
        public async Task<SortResultDTO> SortAsync(List<int> value)
        {
            var result = new List<int>(value.Count());
            for (int i = 0; i < value.Count; i++)
            {
                result.Add(value[value.Count() - 1 - i]);
            }
            return new SortResultDTO() { SortedValues = result };
        }
    }
}
