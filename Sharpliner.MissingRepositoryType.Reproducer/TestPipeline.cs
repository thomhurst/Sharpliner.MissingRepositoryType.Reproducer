using Sharpliner.AzureDevOps;

namespace Sharpliner.MissingRepositoryType.Reproducer;

public class TestPipeline : SingleStagePipelineDefinition
{
    public override string TargetFile { get; } = "foo.yml";

    public override SingleStagePipeline Pipeline { get; } = new()
    {
        Trigger = new Trigger("main"),
        Resources = new Resources
        {
            Repositories =
            {
                new RepositoryResource("sharpliner")
                {
                    Name = "sharpliner/sharpliner", Type = RepositoryType.Git
                }
            }
        }
    };
}
