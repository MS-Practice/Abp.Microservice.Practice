using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Abp.Microservice.Practice
{
    [DependsOn(
        typeof(PracticeApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class PracticeHttpApiModule : AbpModule
    {
        
    }
}
