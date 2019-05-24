using Abp.Microservice.Practice.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Microservice.Practice
{
    public class PracticePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(PracticePermissions.GroupName, L("Permission:Practice"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PracticeResource>(name);
        }
    }
}