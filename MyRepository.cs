namespace LearningWithNamDotNet
{
    public class MyRepository : IRepository
    {
        private readonly ILogger<MyRepository> logger;

        public MyRepository(ILogger<MyRepository> logger)
        {
            // Initialization code if needed
            this.logger = logger;

            logger.LogInformation("MyRepository initialized.");
        }
        public string GetByID(string id)
        {
            return $"Data for ID: {id}";
        }
    }
}
