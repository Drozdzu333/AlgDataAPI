namespace Algorithms.API.Services
{
    public interface ISortService
    {
        Task<SortResultDTO> SortAsync(List<int> value);
    }
}
