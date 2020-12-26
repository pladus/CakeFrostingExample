using Cake.Common.Build;
using Cake.Common.Diagnostics;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Test;
using Cake.Frosting;

namespace Build.Tasks
{
    [Dependency(typeof(Build))]
    public sealed class UnitTestsRun : FrostingTask<Context>
    {
        public override void Run(Context context)
        {
            context.Information("Running unit tests...");
            context.DotNetCoreTest("");
        }
    }
}