﻿using Volo.Abp;
using Volo.Abp.Modularity;

namespace Abp.Microservice.Practice
{
    public abstract class PracticeTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
