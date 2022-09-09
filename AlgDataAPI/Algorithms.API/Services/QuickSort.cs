namespace Algorithms.API.Services
{
    public class QuickSort : BaseSortService
    {
        private List<Task> sortingTasks;
        public QuickSort(TimeCounter time): base(time) { }
        override internal protected async Task EnforceSortAsync(List<int> insertList)
        {
            sortingTasks = new List<Task>();
            sortingTasks.Add(QuickSortMethod(insertList, 0, insertList.Count() - 1));
            Task.WaitAll(sortingTasks.ToArray());
        }
        private async Task QuickSortMethod(List<int> list, int leftIndex, int rightIndex)
        {
            int i, j, pivot;
            i = leftIndex;
            j = rightIndex;
            pivot = list[leftIndex];
            while (i <= j)
            {
                while (list[i] < pivot)
                    i++; _countOfComparisons++;

                while (list[j] > pivot)
                    j--; _countOfComparisons++;
                if (i <= j)
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
                _countOfComparisons++;
            }

            if (leftIndex < j)
                sortingTasks.Add(QuickSortMethod(list, leftIndex, j));
            if (i < rightIndex)
                sortingTasks.Add(QuickSortMethod(list, i, rightIndex));
        }
    }
}
