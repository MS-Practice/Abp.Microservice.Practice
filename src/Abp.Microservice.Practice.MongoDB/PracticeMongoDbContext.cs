using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Microservice.Practice.MongoDB
{
    [ConnectionStringName("Practice")]
    public class PracticeMongoDbContext : AbpMongoDbContext, IPracticeMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = PracticeConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigurePractice(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}