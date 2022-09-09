namespace Algorithms.API.Services
{
    public class MergeSort : BaseSortService
    {
        public MergeSort(TimeCounter time) : base(time) { }
        override internal protected async Task EnforceSortAsync(List<int> insertList)
        {
            Split(insertList);
        }
        private void Split(List<int> list)
        {
            int length = list.Count;
            if (length <= 1) return;

            int middle = length / 2;
            List<int> leftList = new(middle);
            List<int> rightList = new(list.Count - middle);

            int i = 0;
            int j = 0;

            for (i = 0; i < length; i++)
            {
                if (i < middle)
                {
                    leftList.Add(list[i]);
                }
                else
                {
                    rightList.Add(list[i]);
                }
            }
            Split(leftList);
            Split(rightList);
            Merge(leftList, rightList, list);
        }
        private void Merge(List<int> leftList, List<int> rightList, List<int> list)
        {
            int leftSize = list.Count / 2;
            int rightSize = list.Count - leftSize;
            int i = 0, l = 0, r = 0;
            while (l < leftSize && r < rightSize)
            {
                if (leftList[l] < rightList[r])
                {
                    list[i] = leftList[l];
                    i++;
                    l++;
                }
                else
                {
                    list[i] = rightList[r];
                    i++;
                    r++;
                }
            }
            while (l < leftSize)
            {
                list[i] = leftList[l];
                i++;
                l++;
            }
            while (r < rightSize)
            {
                list[i] = rightList[r];
                i++;
                r++;
            }
        }
    }
}
