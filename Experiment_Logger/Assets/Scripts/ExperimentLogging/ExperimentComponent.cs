using System.Collections;
using System.Collections.Generic;

namespace ExperimentLogging
{
    /**
     * Enthält alle Informationen die für einen Experimentschritt (Scene) persistiert werden sollen.
     * @author: Philipp Klinke <philipp.klinke@offis.de>
     */
    public class ExperimentComponent
    {
        private static int _counter = 1;
        
        /**
         * Name will be used as naming for the created audit file.
         * Defaults to "stepN" where n = {1, 2, ... n}
         */
        private string _name;

        /**
         * Dynamic Values which should be written to experiment audit log for this step
         */
        private Hashtable _values;

        public ExperimentComponent()
        {
            _name = $"step{_counter++}";
            this._values = new Hashtable();
        }

        public void AddValue(string key, object value)
        {
            _values.Add(key, value);
        }

        public object GetValue(string key)
        {
            return _values[key];
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Hashtable GetValues()
        {
            return _values;
        }
        
    }
}