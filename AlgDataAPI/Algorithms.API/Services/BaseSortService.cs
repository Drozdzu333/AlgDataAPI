namespace Algorithms.API.Services
{
    public class BaseSortService : ISortService
    {
        private readonly TimeCounter _timeCounter;
        internal int _countOfComparisons;
        internal protected List<int> _resultList;
        public BaseSortService(TimeCounter timeCounter)
        {
            _timeCounter = timeCounter;
            _countOfComparisons = 0;
        }

        public async Task<SortResultDTO> SortAsync(List<int> insertList)
        {
            _timeCounter.StartCounter();
            _countOfComparisons = 0;
            _resultList = insertList;
            await EnforceSort(insertList);
            return new SortResultDTO() {
            SortedValues = _resultList,
                TimeOfCalculation = _timeCounter.StopCounter(),
                CountOfComparisons = _countOfComparisons
            };
        }
        internal protected virtual async Task EnforceSort(List<int> value) { }
        internal protected void Swap(int index1, int index2)
        {
            int valueHolder = _resultList[index2];
            _resultList[index2] = _resultList[index1];
            _resultList[index1] = valueHolder;
        }
    }
}
