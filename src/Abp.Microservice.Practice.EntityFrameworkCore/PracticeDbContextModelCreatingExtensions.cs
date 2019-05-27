using System;
using Abp.Microservice.Practice.Domain;
using Abp.Microservice.Practice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Abp.Microservice.Practice.EntityFrameworkCore
{
    public static class PracticeDbContextModelCreatingExtensions
    {
        public static void ConfigurePractice(
            this ModelBuilder builder,
            Action<PracticeModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new PracticeModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);

            builder.Entity<Menu>()
                .ToTable("Menus")
                .Property(p => p.Name).IsRequired().HasMaxLength(MenuContractConsts.NameMaxLength);
            builder.Entity<Menu>()
                .HasKey(p => p.Id);
            builder.Entity<Menu>(p =>
            {
                p.Property(m => m.Url).IsRequired();
            });
            /* Configure all entities here. Example:
            
            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                //b.ToTable(options.TablePrefix + "Questions", options.Schema);
                
                //Properties
                //b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Configure relations
                //b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Configure indexes
                //b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}