using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.Microservice.Practice.EntityFrameworkCore
{
    public class PracticeModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public PracticeModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = PracticeConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = PracticeConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}