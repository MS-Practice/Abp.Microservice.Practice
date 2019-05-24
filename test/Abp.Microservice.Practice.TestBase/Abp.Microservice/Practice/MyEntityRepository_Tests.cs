using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace Abp.Microservice.Practice
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : PracticeTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
