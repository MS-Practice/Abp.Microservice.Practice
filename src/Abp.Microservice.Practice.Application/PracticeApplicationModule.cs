using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace Abp.Microservice.Practice
{
    [DependsOn(
        typeof(PracticeDomainModule),
        typeof(PracticeApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class PracticeApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<PracticeApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
