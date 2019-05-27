using Microsoft.Extensions.DependencyInjection;
using Abp.Microservice.Practice.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.Microservice.Practice
{
    [DependsOn(
        typeof(PracticeDomainSharedModule)
        )]
    public class PracticeDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<PracticeDomainModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<PracticeResource>().AddVirtualJson("/Abp.Microservice.Practice/Localization");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Practice", typeof(PracticeResource));
            });
        }
    }
}
