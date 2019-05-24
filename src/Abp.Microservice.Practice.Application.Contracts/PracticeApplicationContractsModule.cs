using Microsoft.Extensions.DependencyInjection;
using Abp.Microservice.Practice.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.Microservice.Practice
{
    [DependsOn(
        typeof(PracticeDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class PracticeApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<PracticeApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<PracticeResource>()
                    .AddVirtualJson("/Abp.Microservice/Practice/Localization/ApplicationContracts");
            });
        }
    }
}
