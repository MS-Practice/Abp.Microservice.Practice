using Volo.Abp.Modularity;

namespace Abp.Microservice.Practice
{
    [DependsOn(
        typeof(PracticeApplicationModule),
        typeof(PracticeDomainTestModule)
        )]
    public class PracticeApplicationTestModule : AbpModule
    {

    }
}
