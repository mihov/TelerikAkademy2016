using System;

namespace VersionAttribute
{
    [Version(VersionAttribute.Type.Class, "StartUp Version Attribute", "6.14")]
    public class StartUp
    {
        static void Main()
        {
            var type = typeof(VersionAttribute);
            var classAttributes = type.GetCustomAttributes(true);

            foreach (var attribute in classAttributes)
            {
                Console.WriteLine("{0}: {1}     Version: {2}", attribute.Component, attribute.Name, attribute.Version);
            }
        }
    }
}
