namespace AlgDataGateway.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        [HttpPost]
        [Route("BubbleSort/")]
        public async Task<ActionResult<SortResultDTO>> BubbleSort([FromBody] List<int> value)
        {
            throw new NotImplementedException();
            //return Ok(await bubbleSort.SortAsync(value));
        }
        [HttpPost]
        [Route("InsertSort/")]
        public async Task<ActionResult<SortResultDTO>> InsertSort([FromBody] List<int> value)
        {
            throw new NotImplementedException();
            //return Ok(await insertSort.SortAsync(value));
        }
        [HttpPost]
        [Route("MergeSort/")]
        public async Task<ActionResult<SortResultDTO>> MergeSort([FromBody] List<int> value)
        {
            throw new NotImplementedException();
            //return Ok(await mergeSort.SortAsync(value));
        }
        [HttpPost]
        [Route("QuickSort/")]
        public async Task<ActionResult<SortResultDTO>> QuickSort([FromBody] List<int> value)
        {
            throw new NotImplementedException();
            //return Ok(await quickSort.SortAsync(value));
        }
        [HttpPost]
        [Route("SelectSort/")]
        public async Task<ActionResult<SortResultDTO>> SelectSort([FromBody] List<int> value)
        {
            throw new NotImplementedException();
            //return Ok(await selectSort.SortAsync(value));
        }
        [HttpPost]
        [Route("TreeSort/")]
        public async Task<ActionResult<SortResultDTO>> TreeSort([FromBody] List<int> value)
        {
            throw new NotImplementedException();
            //return Ok(await treeSort.SortAsync(value));
        }
    }
}
