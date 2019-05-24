using Abp.Microservice.Practice.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Microservice.Practice
{
    [DependsOn(
        typeof(PracticeEntityFrameworkCoreTestModule)
        )]
    public class PracticeDomainTestModule : AbpModule
    {
        
    }
}
