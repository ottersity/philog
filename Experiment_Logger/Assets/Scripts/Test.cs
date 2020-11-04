using System;
using UnityEngine;
using Zenject;

namespace ExperimentLogging
{
    public class Test : MonoBehaviour
    {
        private ExperimentComponent _experimentComponent;

        [Inject]
        public void Init(ExperimentComponent experimentComponent)
        {
            _experimentComponent = experimentComponent;
            _experimentComponent.AddValue("asdf", 5);
        }
    }
}