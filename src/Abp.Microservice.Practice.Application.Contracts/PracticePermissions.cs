using Volo.Abp.Reflection;

namespace Abp.Microservice.Practice
{
    public class PracticePermissions
    {
        public const string GroupName = "Practice";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(PracticePermissions));
        }
    }
}