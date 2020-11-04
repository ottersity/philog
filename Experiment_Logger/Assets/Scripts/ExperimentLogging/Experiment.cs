using System;
using System.Collections.Generic;

namespace ExperimentLogging
{
    /**
     * Enthält alle Informationen eines Experiments, welche gespeichert / geloggt werden sollen.
     * Ein Experiment besteht mehreren ExperimentComponents und seinen Metadaten.
     * @author: Philipp Klinke <philipp.klinke@offis.de>
     */
    public class Experiment
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private int _participantId;
        private String _condition;
        private List<ExperimentComponent> _components;
        
        public Experiment()
        {
            _startTime = DateTime.Now;
            _components = new List<ExperimentComponent>();
        }

        public DateTime StartTime
        {
            get => _startTime;
            set => _startTime = value;
        }

        public DateTime EndTime
        {
            get => _endTime;
            set => _endTime = value;
        }

        public int ParticipantId
        {
            get => _participantId;
            set => _participantId = value;
        }

        public string Condition
        {
            get => _condition;
            set => _condition = value;
        }

        public void addComponent(ExperimentComponent component)
        {
            _components.Add(component);
        }
        public List<ExperimentComponent> Components => _components;

    }
}