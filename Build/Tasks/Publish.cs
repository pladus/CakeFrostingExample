using System;
using Cake.Common.Build;
using Cake.Common.Diagnostics;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Publish;
using Cake.Frosting;

namespace Build.Tasks
{
    [Dependency(typeof(UnitTestsRun))]
    public sealed class Publish : FrostingTask<Context>
    {
        public override void Run(Context context)
        {
            context.Information("Publish started");
            context.DotNetCorePublish("./YourApp/YourApp.csproj", new DotNetCorePublishSettings
            {
                Runtime = "linux-x64",
                SelfContained = true,
                Configuration = "Release",
                OutputDirectory = "./Deploy/ReleasePackage",
            });
        }
    }
}