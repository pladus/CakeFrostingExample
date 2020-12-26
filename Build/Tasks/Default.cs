using Cake.Common.Diagnostics;
using Cake.Common.Tools.DotNetCore;
using Cake.Frosting;

namespace Build.Tasks
{
    /// <summary>
    /// Entry for Cake and dependency graph root
    /// </summary>
    [Dependency(typeof(DockerBuild))]
    public sealed class Default : FrostingTask<Context>
    {
    }
}