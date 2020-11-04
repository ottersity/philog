using System;
using UnityEngine;
using Zenject;

namespace ExperimentLogging
{
    public class Test2 : MonoBehaviour
    {
        private ExperimentComponent _experimentComponent;
        
        private Experiment _experiment;
        private CsvWriter _writer;
        
        [Inject]
        public void Init(ExperimentComponent experimentComponent, Experiment experiment, CsvWriter writer)
        {
            _experimentComponent = experimentComponent;
            _experiment = experiment;
            _writer = writer;
        }

        private void Start()
        {
            Debug.Log(_experiment.Components.Count);
            _writer.Write();
        }
    }
}