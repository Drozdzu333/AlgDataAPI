using System.Text;

namespace AlgDataGateway.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly Uri _connectionString;
        public AlgorithmsController(IConfiguration configuration)
        {
            _connectionString = new Uri(configuration.GetSection("ConnectionStrings:Algorithms").Value);
        }
        [HttpPost]
        [Route("BubbleSort/")]
        public async Task<ActionResult<SortResultDTO>> BubbleSort([FromBody] List<int> value)
            => await Connect(value);
        [HttpPost]
        [Route("InsertSort/")]
        public async Task<ActionResult<SortResultDTO>> InsertSort([FromBody] List<int> value)
            => await Connect(value);
        [HttpPost]
        [Route("MergeSort/")]
        public async Task<ActionResult<SortResultDTO>> MergeSort([FromBody] List<int> value)
            => await Connect(value);
        [HttpPost]
        [Route("QuickSort/")]
        public async Task<ActionResult<SortResultDTO>> QuickSort([FromBody] List<int> value)
            => await Connect(value);
        [HttpPost]
        [Route("SelectSort/")]
        public async Task<ActionResult<SortResultDTO>> SelectSort([FromBody] List<int> value)
            => await Connect(value);
        [HttpPost]
        [Route("TreeSort/")]
        public async Task<ActionResult<SortResultDTO>> TreeSort([FromBody] List<int> value)
            => await Connect(value);

        private async Task<ActionResult<SortResultDTO>> Connect(List<int> value)
        {
            var queryString = HttpContext.Request.Path.Value.Substring(1);
            var content = new StringContent(JsonSerializer.Serialize(value).ToString(), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_connectionString + queryString, content);
            if (response.IsSuccessStatusCode)
            {
                var responceContent = await response.Content.ReadFromJsonAsync<SortResultDTO>();
                return Ok(responceContent);
            }
            return BadRequest();
        }
    }
}
