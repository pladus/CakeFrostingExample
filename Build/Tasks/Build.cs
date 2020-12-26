using Cake.Common.Diagnostics;
using Cake.Common.Tools.DotNetCore;
using Cake.Frosting;

namespace Build.Tasks
{
    [Dependency(typeof(Restore))]
    public sealed class Build : FrostingTask<Context>
    {
        public override void Run(Context context)
        {
            context.Information("Build started...");
            context.DotNetCoreBuild("");
        }
    }
}