#load "nuget:https://www.nuget.org/api/v2?package=Cake.VsCode.Recipe&version=0.1.0"

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            title: "gitpitch-vscode",
                            repositoryOwner: "gep13-oss",
                            repositoryName: "gitpitch-vscode",
                            appVeyorAccountName: "gep13oss",
                            shouldRunGitVersion: true);

BuildParameters.PrintParameters(Context);

Build.Run();
