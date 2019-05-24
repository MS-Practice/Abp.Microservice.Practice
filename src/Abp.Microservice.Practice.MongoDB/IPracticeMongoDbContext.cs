using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Microservice.Practice.MongoDB
{
    [ConnectionStringName("Practice")]
    public interface IPracticeMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
