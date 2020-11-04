using ExperimentLogging;
using Zenject;

public class SceneDependencyInstaller: MonoInstaller
{
    private Experiment _experiment;
    
    [Inject]
    public void Init(Experiment experiment)
    {
        _experiment = experiment;
    }
    public override void InstallBindings()
    {
        Container
            .Bind<ExperimentComponent>()
            .AsSingle()
            .OnInstantiated<ExperimentComponent>((ctx, component) => _experiment.addComponent(component));
    }
}
