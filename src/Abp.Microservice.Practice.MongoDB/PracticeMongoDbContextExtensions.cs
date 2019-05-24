using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Abp.Microservice.Practice.MongoDB
{
    public static class PracticeMongoDbContextExtensions
    {
        public static void ConfigurePractice(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new PracticeMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}