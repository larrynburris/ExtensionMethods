using System;

namespace CloudPatterns.CircuitBreaker
{
    public interface ICircuitBreakerStateStore
    {
        CircuitBreakerState State { get; }
        Exception LastException { get; }
        DateTime? LastStateChangeDateUtc { get; }
        void Trip(Exception ex);
        void Reset();
        void HalfOpen();
        bool IsClosed { get; }
    }
}
