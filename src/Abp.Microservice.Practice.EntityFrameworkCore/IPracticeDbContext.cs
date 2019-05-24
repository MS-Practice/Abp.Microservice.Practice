using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Microservice.Practice.EntityFrameworkCore
{
    [ConnectionStringName("Practice")]
    public interface IPracticeDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}