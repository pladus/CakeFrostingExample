using System;
using System.Collections.Generic;
using System.Linq;
using Cake.Common.Build;
using Cake.Common.Diagnostics;
using Cake.Common.IO;
using Cake.Common.Tools.Cake;
using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Publish;
using Cake.Core.IO;
using Cake.Docker;
using Cake.Frosting;

namespace Build.Tasks
{
    [Dependency(typeof(Publish))]
    public sealed class DockerBuild : FrostingTask<Context>
    {
        public override void Run(Context context)
        {
            var appVersion = context.Arguments.GetArguments("AppVersion").FirstOrDefault();

            context.Information("Docker image building started...");
            context.CopyFile("./Dockerfile", "./Deploy/Dockerfile");
            context.DockerBuild(new DockerImageBuildSettings
            {
                WorkingDirectory = "./Deploy",
                BuildArg = new[] {$"AppVersion={appVersion}"},
                Tag = new[] {$"mp-api:v.{appVersion}"}
            }, ".");
        }
    }
}