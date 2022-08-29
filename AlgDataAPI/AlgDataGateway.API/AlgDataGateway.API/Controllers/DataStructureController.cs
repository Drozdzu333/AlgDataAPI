namespace AlgDataGateway.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStructureController : ControllerBase
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private readonly Uri _connectionString;
        public DataStructureController(IConfiguration configuration)
        {
            _connectionString = new Uri(configuration.GetSection("ConnectionStrings:DataStructure").Value);
        }
        // GET api/<DataStructureController>/Stack
        [HttpGet("{type}")]
        public async Task<ActionResult<DataModel>> Get(string type)
        {
            var queryString = char.ToUpper(type[0]) + type.Substring(1).ToLower();
            var result = await _httpClient.GetAsync(_connectionString + queryString);
            if (result.IsSuccessStatusCode)
            {
                var resultString = JsonSerializer.Deserialize<DataModel>(await result.Content.ReadAsStringAsync());
                return Ok(resultString);
            }
            return BadRequest();
        }
    }
}
