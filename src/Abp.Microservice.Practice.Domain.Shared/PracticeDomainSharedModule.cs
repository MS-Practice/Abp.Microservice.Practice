using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Abp.Microservice.Practice.Localization;

namespace Abp.Microservice.Practice
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class PracticeDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<PracticeResource>("en");
            });
        }
    }
}
