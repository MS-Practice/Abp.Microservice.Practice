using Abp.Microservice.Practice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Microservice.Practice.EntityFrameworkCore
{
    [ConnectionStringName("Practice")]
    public class PracticeDbContext : AbpDbContext<PracticeDbContext>, IPracticeDbContext
    {
        public static string TablePrefix { get; set; } = PracticeConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = PracticeConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Menu> Menus { get; set; }
        public PracticeDbContext(DbContextOptions<PracticeDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigurePractice(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}