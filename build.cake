var target = Argument("target", "Default");

Task("Default")
    .Does(() => {
        MSBuild("./src/CakeSample/CakeSample.sln");
    });

RunTarget(target);