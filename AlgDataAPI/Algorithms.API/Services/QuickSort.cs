namespace Algorithms.API.Services
{
    public class QuickSort : BaseSortService
    {
        public QuickSort(TimeCounter time): base(time) { }
        override internal protected async Task EnforceSortAsync(List<int> insertList)
        {
            int i, j;
            for (i = 0; i < _resultList.Count - 1; i++)
                for (j = 0; j < _resultList.Count - i - 1; j++)
                {
                    if (_resultList[j] > _resultList[j + 1])
                        Swap(j, j + 1);
                    _countOfComparisons++;
                }
        }
    }
}
