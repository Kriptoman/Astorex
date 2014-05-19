using System;
using PostSharp.Aspects;
using PostSharp.Extensibility;
using TaskManager.Infrastructure.Logging;

namespace TaskManager.Infrastructure.Attributes
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    [HasInheritedAttribute]
    [MulticastAttributeUsage(MulticastTargets.Method, AllowMultiple = true, TargetMemberAttributes = MulticastAttributes.NonAbstract)]
    public class DatabaseExceptionHandlerAttribute : OnMethodBoundaryAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            var logger = new AppLogger();

            logger.LogError(args.Exception);
        } 
    }
}