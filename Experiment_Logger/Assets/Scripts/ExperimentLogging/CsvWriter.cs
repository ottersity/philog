using System;
using UnityEngine;
using Zenject;
using CsvHelper;

namespace ExperimentLogging
{
    public class CsvWriter
    {
        private Experiment _experiment;

        [Inject]
        public CsvWriter(Experiment experiment)
        {
            _experiment = experiment;
        }

        // Format for iso 8601 ("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")

        public void Write()
        {
            foreach (var component in _experiment.Components)
            {
                foreach (var properties in typeof(ExperimentComponent).GetProperties())
                {
                    Console.Out.WriteLine(properties.Attributes);
                }
                Debug.Log($"Name: {component.Name}");
                         
                foreach (var key in component.GetValues().Keys)
                {
                    Debug.Log($"{key} : {component.GetValues()[key]}");
                }
            }
        }
    }
}