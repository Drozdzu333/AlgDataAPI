namespace Algorithms.API.Services
{
    public class SelectSort : BaseSortService
    {
        public SelectSort(TimeCounter time) : base(time) { }
        override internal protected async Task EnforceSort(List<int> insertList)
        {
            int i, j, currentMin, indexOfMin;
            for (i = 0; i < _resultList.Count - 1; i++)
            {
                currentMin = _resultList[i];
                indexOfMin = i;
                for (j = i + 1; j < _resultList.Count; j++)
                {
                    if(currentMin>= _resultList[j])
                    {
                        currentMin = _resultList[j];
                        indexOfMin = j;
                    }
                    _countOfComparisons++;
                }
                _resultList[indexOfMin] = _resultList[i];
                _resultList[i] = currentMin;
            }
        }
    }
}
