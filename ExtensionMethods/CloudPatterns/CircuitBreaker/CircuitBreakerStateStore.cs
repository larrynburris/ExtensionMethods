using System;
using System.Collections.Concurrent;

namespace CloudPatterns.CircuitBreaker
{
    public class CircuitBreakerStateStore : ICircuitBreakerStateStore
    {
        private ConcurrentStack<Exception> _exceptionsSinceLastStateChange;

        public CircuitBreakerStateStore(string key)
        {
            this._exceptionsSinceLastStateChange = new ConcurrentStack<Exception>();
            this.Name = key;
        }

        public string Name { get; private set; }

        private CircuitBreakerState _State;
        public CircuitBreakerState State
        {
            get
            {
                if (this._State.Equals(CircuitBreakerState.None))
                {
                    this._State = CircuitBreakerState.Closed;
                }
                return this._State;
            }
            private set
            {
                this._State = value;
            }
        }

        public Exception LastException
        {
            get
            {
                Exception lastException = null;
                _exceptionsSinceLastStateChange.TryPeek(out lastException);
                return lastException;
            }
        }

        public void Trip(Exception ex)
        {
            this.ChangeState(CircuitBreakerState.Open);
            _exceptionsSinceLastStateChange.Push(ex);
        }

        public void Reset()
        {
            this.ChangeState(CircuitBreakerState.Closed);
            _exceptionsSinceLastStateChange.Clear();
        }

        public void HalfOpen()
        {
            this.ChangeState(CircuitBreakerState.HalfOpen);
        }

        public bool IsClosed
        {
            get
            {
                return this.State.Equals(CircuitBreakerState.Closed);
            }
        }

        private DateTime? _lastStateChangeDateUtc;
        public DateTime? LastStateChangeDateUtc
        {
            get
            {
                return this._lastStateChangeDateUtc;
            }
            private set
            {
                this._lastStateChangeDateUtc = value;
            }
        }

        public void ChangeState(CircuitBreakerState state)
        {
            this.State = state;
            this.LastStateChangeDateUtc = DateTime.UtcNow;
        }
    }
}
