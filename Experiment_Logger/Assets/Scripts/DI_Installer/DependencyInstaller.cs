using Zenject;

namespace ExperimentLogging
{
    public class DependencyInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<Experiment>().AsSingle();
            Container.Bind<CsvWriter>().AsSingle();
        }
    }
}