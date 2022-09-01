namespace Algorithms.API.Services
{
    public class InsertSort : BaseSortService
    {
        public InsertSort(TimeCounter timeCounter): base(timeCounter) { }
        override internal protected async Task EnforceSort(List<int> insertList)
        {

            int i, j;
            for (i = 0; i < _resultList.Count - 1; i++)
                if (_resultList[i] >= _resultList[i + 1])
                {
                    j = i;
                    do
                    {
                        Swap(j, j + 1);
                        j--;
                        _countOfComparisons++;
                    } while (_resultList[j] > _resultList[j + 1]);
                }
        }
    }
}