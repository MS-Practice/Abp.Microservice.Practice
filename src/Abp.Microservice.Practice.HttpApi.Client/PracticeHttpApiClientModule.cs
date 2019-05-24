using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Abp.Microservice.Practice
{
    [DependsOn(
        typeof(PracticeApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class PracticeHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Practice";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(PracticeApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
