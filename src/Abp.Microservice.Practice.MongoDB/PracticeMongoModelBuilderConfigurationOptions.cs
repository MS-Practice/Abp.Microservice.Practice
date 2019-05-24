using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Abp.Microservice.Practice.MongoDB
{
    public class PracticeMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public PracticeMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = PracticeConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}