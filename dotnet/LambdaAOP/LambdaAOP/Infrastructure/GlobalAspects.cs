using PostSharp.Extensibility;
using PostSharp.Patterns.Diagnostics;

[assembly: Log(AttributePriority = 1, AttributeTargetMemberAttributes = MulticastAttributes.Protected | MulticastAttributes.Internal | MulticastAttributes.Public)]
[assembly: Log(AttributePriority = 2, AttributeExclude = true, AttributeTargetMembers = "get_*")]

namespace LambdaAOP.Infrastructure
{
    class GlobalAspects
    {
    }
}
