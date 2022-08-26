namespace DataStructure.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStructureController : ControllerBase
    {
        private readonly DataStructureService _dataStructureService;

        public DataStructureController(DataStructureService dataStructureService)
        {
            _dataStructureService = dataStructureService;
        }

        // GET api/<DataStructureController>/Stack
        [HttpGet("{type}")]
        public async Task<ActionResult<DataModel>> Get(string type)
        {
            var result = await _dataStructureService.GetAsync(type);
            return Ok(result);
        }
    }
}
