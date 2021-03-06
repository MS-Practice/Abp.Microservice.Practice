﻿using Abp.Microservice.Practice.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Microservice.Practice.EntityFrameworkCore
{
    [DependsOn(
        typeof(PracticeDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class PracticeEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PracticeDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<IMenuRepository, MenuRepository>();
            });
        }
    }
}