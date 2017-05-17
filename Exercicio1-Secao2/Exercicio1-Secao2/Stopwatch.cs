using System;

namespace Exercicio1_Secao2 { 

class Stopwatch
    {
        private bool _isRunning;

        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }


        public Stopwatch()
        {
            _isRunning = false;
        }


        public DateTime Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Start");

            _isRunning = true;
            return DateTime.Now;
        }

        public DateTime Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stop");

            _isRunning = false;
            return DateTime.Now;
        }

        public TimeSpan Difference(DateTime start, DateTime stop)
        {
            return stop - start;
        }

    }
}
