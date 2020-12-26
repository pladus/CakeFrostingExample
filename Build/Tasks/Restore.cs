using Cake.Common.Diagnostics;
using Cake.Common.Tools.DotNetCore;
using Cake.Frosting;

namespace Build.Tasks
{
    public sealed class Restore : FrostingTask<Context>
    {
        public override void Run(Context context)
        {
            context.Information("Restore started...");
            context.DotNetCoreRestore("");
        }
    }
}