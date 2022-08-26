namespace Algorithms.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private readonly BubbleSort bubbleSort;
        private readonly InsertSort insertSort;
        private readonly MergeSort mergeSort;
        private readonly QuickSort quickSort;
        private readonly SelectSort selectSort;
        private readonly TreeSort treeSort;

        public AlgorithmsController(
            BubbleSort bubbleSort,
            InsertSort insertSort,
            MergeSort mergeSort,
            QuickSort quickSort,
            SelectSort selectSort,
            TreeSort treeSort
            )
        {
            this.bubbleSort = bubbleSort;
            this.insertSort = insertSort;
            this.mergeSort = mergeSort;
            this.quickSort = quickSort;
            this.selectSort = selectSort;
            this.treeSort = treeSort;

        }

        [HttpPost]
        [Route("BubbleSort/")]
        public async Task<ActionResult<SortResultDTO>> BubbleSort([FromBody] List<int> value)
        {
            return Ok(await bubbleSort.SortAsync(value));
        }
        [HttpPost]
        [Route("InsertSort/")]
        public async Task<ActionResult<SortResultDTO>> InsertSort([FromBody] List<int> value)
        {
            return Ok(await insertSort.SortAsync(value));
        }
        [HttpPost]
        [Route("MergeSort/")]
        public async Task<ActionResult<SortResultDTO>> MergeSort([FromBody] List<int> value)
        {
            return Ok(await mergeSort.SortAsync(value));
        }
        [HttpPost]
        [Route("QuickSort/")]
        public async Task<ActionResult<SortResultDTO>> QuickSort([FromBody] List<int> value)
        {
            return Ok(await quickSort.SortAsync(value));
        }
        [HttpPost]
        [Route("SelectSort/")]
        public async Task<ActionResult<SortResultDTO>> SelectSort([FromBody] List<int> value)
        {
            return Ok(await selectSort.SortAsync(value));
        }
        [HttpPost]
        [Route("TreeSort/")]
        public async Task<ActionResult<SortResultDTO>> TreeSort([FromBody] List<int> value)
        {
            return Ok(await treeSort.SortAsync(value));
        }
    }
}
