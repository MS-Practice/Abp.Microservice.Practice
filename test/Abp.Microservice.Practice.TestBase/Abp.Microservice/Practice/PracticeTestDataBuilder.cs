using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace Abp.Microservice.Practice
{
    public class PracticeTestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private PracticeTestData _testData;

        public PracticeTestDataBuilder(
            IGuidGenerator guidGenerator,
            PracticeTestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}