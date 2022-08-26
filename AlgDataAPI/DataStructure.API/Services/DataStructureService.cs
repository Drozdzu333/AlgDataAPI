namespace DataStructure.API.Services
{
    public class DataStructureService
    {
        private readonly IMongoCollection<DataModel> _mongoCollection;
        public DataStructureService(IOptions<AlgNStructDatabaseSettings> options)
        {
            var mongoClient= new MongoClient(options.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(options.Value.DatabaseName);
            _mongoCollection = mongoDatabase.GetCollection<DataModel>(options.Value.DataCollectionName);
        }
        public async Task<DataModel?> GetAsync(string type)
        {
            var result = await _mongoCollection.Find(x => x.DataTypeName == type).FirstOrDefaultAsync();
            return (DataModel) result;
        }
    }
}
