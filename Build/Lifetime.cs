using Cake.Common.Diagnostics;
using Cake.Common.IO;
using Cake.Core;
using Cake.Frosting;

public sealed class Lifetime : FrostingLifetime<Context>
{
    public override void Setup(Context context)
    {
        context.Information("Setting things up...");
    }

    public override void Teardown(Context context, ITeardownContext info)
    {
        context.Information("Tearing things down...");

        var deployDirectory = "./Deploy";

        if (!context.DirectoryExists(deployDirectory)) return;
        
        context.DeleteDirectory(deployDirectory, new DeleteDirectorySettings
        {
            Force = true,
            Recursive = true
        });
    }
}