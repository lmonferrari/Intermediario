using System;

namespace Exercicio1_Secao2
{

    class Stopwatch
    {
        private bool _isRunning;
        private DateTime _startTime;
        private DateTime _stopTime;

        public Stopwatch()
        {
            _isRunning = false;
        }

        public void Start(DateTime start)
        {
            if (_isRunning)
                throw new InvalidOperationException("Start");

            _isRunning = true;
            this._startTime = start;
        }

        public void Stop(DateTime stop)
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stop");

            _isRunning = false;
            this._stopTime = stop;
        }

        public TimeSpan Difference()
        {
            return this._stopTime - this._startTime;
        }
    }
}
